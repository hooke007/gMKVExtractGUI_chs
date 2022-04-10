﻿using gMKVToolNix.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace gMKVToolNix
{
    public partial class frmJobManager : gForm
    {
        private readonly StringBuilder _ExceptionBuilder = new StringBuilder();
        private readonly IFormMain _MainForm = null;
        private int _CurrentJob = 0;
        private int _TotalJobs = 0;
        private gMKVExtract _gMkvExtract = null;
        private bool _ExtractRunning = false;
        private gSettings _Settings = null; 
        private bool _FromConstructor = false;

        private BindingList<gMKVJobInfo> _JobList = new BindingList<gMKVJobInfo>();

        private Boolean _AbortAll = false;
        
        public frmJobManager(IFormMain argMainForm)
        {
            try
            {
                InitializeComponent();

                _MainForm = argMainForm;

                Icon = Icon.ExtractAssociatedIcon(GetExecutingAssemblyLocation());
                Text = String.Format("gMKVExtractGUI v{0} -- Job Manager", GetCurrentVersion());

                _FromConstructor = true;

                // Load settings
                _Settings = new gSettings(this.GetCurrentDirectory());
                _Settings.Reload();

                chkShowPopup.Checked = _Settings.ShowPopupInJobManager;

                grdJobs.DataSource = _JobList;

                _FromConstructor = false;

                SetAbortStatus(false);

                // Initialize the DPI aware scaling
                InitDPI();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                _FromConstructor = false;
                ShowErrorMessage(ex.Message);
            }
        }

        private void SetJobsList(BindingList<gMKVJobInfo> argJobList)
        {
            try
            {
                _JobList = argJobList;
                grdJobs.DataSource = _JobList;
                grdJobs.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);                
            }
        }

        public void AddJob(gMKVJobInfo argJobInfo)
        {
            // Check if the same job already exists
            foreach (var jobInfo in _JobList)
            {
                gMKVJob j = jobInfo.Job;
                gMKVJob argJ = argJobInfo.Job;
                if (j.ExtractionMode == argJ.ExtractionMode
                    && j.MKVToolnixPath == argJ.MKVToolnixPath
                    && j.ParametersList.Equals(argJ.ParametersList))
                {
                    return;
                }
            }

            _JobList.Add(argJobInfo);
        }

        private void SetAbortStatus(bool argStatus)
        {
            btnAbort.Enabled = argStatus;
            btnAbortAll.Enabled = argStatus;
        }

        private void SetActionStatus(bool argStatus)
        {
            btnRemove.Enabled = argStatus;
            btnRunAll.Enabled = argStatus;
            btnLoadJobs.Enabled = argStatus;
            btnSaveJobs.Enabled = argStatus;
        }

        void _gMkvExtract_MkvExtractTrackUpdated(string filename, string trackName)
        {
            this.Invoke(new UpdateTrackLabelDelegate(UpdateTrackLabel), new object[] { filename, trackName });
            Debug.WriteLine(trackName);
        }

        void _gMkvExtract_MkvExtractProgressUpdated(int progress)
        {
            this.Invoke(new UpdateProgressDelegate(UpdateCurrentProgress), new object[] { progress });
        }

        private void frmJobManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            // To avoid getting disposed
            e.Cancel = true;
            if (_ExtractRunning)
            {
                ShowErrorMessage("There is an extraction process running! Please abort before closing!");
            }
            else
            {
                this.Hide();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdJobs.Rows.Count > 0)
                {
                    if (grdJobs.SelectedRows.Count > 0)
                    {
                        grdJobs.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(r => grdJobs.Rows.Remove(r));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private void RunJobs(List<gMKVJobInfo> argJobInfoList)
        {
            _ExceptionBuilder.Length = 0;
            foreach (gMKVJobInfo jobInfo in argJobInfoList)
            {
                try
                {
                    // check for abort
                    if (_AbortAll)
                    {
                        break;
                    }
                    // get job from jobInfo
                    gMKVJob job = jobInfo.Job;
                    // create the new gMKVExtract object
                    _gMkvExtract = new gMKVExtract(job.MKVToolnixPath);
                    _gMkvExtract.MkvExtractProgressUpdated += _gMkvExtract_MkvExtractProgressUpdated;
                    _gMkvExtract.MkvExtractTrackUpdated += _gMkvExtract_MkvExtractTrackUpdated;
                    // increate the current job index
                    _CurrentJob++;
                    // start the thread
                    Thread myThread = new Thread(new ParameterizedThreadStart(job.ExtractMethod(_gMkvExtract)));
                    jobInfo.StartTime = DateTime.Now;
                    jobInfo.State = JobState.Running;
                    grdJobs.Refresh();
                    myThread.Start(job.ParametersList);

                    btnAbort.Enabled = true;
                    btnAbortAll.Enabled = true;
                    gTaskbarProgress.SetState(this, gTaskbarProgress.TaskbarStates.Normal);
                    Application.DoEvents();
                    while (myThread.ThreadState != System.Threading.ThreadState.Stopped)
                    {
                        Application.DoEvents();
                    }
                    jobInfo.EndTime = DateTime.Now;
                    // check for exceptions
                    if (_gMkvExtract.ThreadedException != null)
                    {
                        jobInfo.State = JobState.Failed;
                        grdJobs.Refresh();
                        throw _gMkvExtract.ThreadedException;
                    }
                    else
                    {
                        jobInfo.State = JobState.Completed;
                        grdJobs.Refresh();
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    _ExceptionBuilder.AppendFormat("Exception for job {0}: {1}{2}", jobInfo.ToString(), ex.Message, Environment.NewLine);
                }
                finally
                {
                    if (_gMkvExtract != null)
                    {
                        _gMkvExtract.MkvExtractProgressUpdated -= _gMkvExtract_MkvExtractProgressUpdated;
                        _gMkvExtract.MkvExtractTrackUpdated -= _gMkvExtract_MkvExtractTrackUpdated;
                    }
                }
            }
        }

        public void UpdateCurrentProgress(Object val)
        {
            prgBrCurrent.Value = Convert.ToInt32(val);
            prgBrTotal.Value = (_CurrentJob - 1) * 100 + Convert.ToInt32(val);
            lblCurrentProgressValue.Text = String.Format("{0}%", Convert.ToInt32(val));
            lblTotalProgressValue.Text = String.Format("{0}%", prgBrTotal.Value / _TotalJobs);
            gTaskbarProgress.SetValue(this, Convert.ToUInt64(val), (UInt64)100);
            grdJobs.Refresh();
            Application.DoEvents();
        }

        public void UpdateTrackLabel(Object filename, Object val)
        {
            txtCurrentTrack.Text = String.Format("{0} from {1}", val, Path.GetFileName((string)filename));
            Application.DoEvents();
        }

        private void btnRunAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetNumberOfJobs(JobState.Ready) == 0)
                {
                    throw new Exception("There are no available jobs to run!");
                }
                List<gMKVJobInfo> jobList = new List<gMKVJobInfo>();
                foreach (DataGridViewRow item in grdJobs.Rows)
                {
                    gMKVJobInfo jobInfo = (gMKVJobInfo)item.DataBoundItem;
                    if (jobInfo.State == JobState.Ready)
                    {
                        jobInfo.State = JobState.Pending;
                        jobList.Add(jobInfo);
                    }
                }
                grdJobs.Refresh();
                PrepareForRunJobs(jobList);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private void PrepareForRunJobs(List<gMKVJobInfo> argJobInfoList)
        {
            bool exceptionOccured = false;
            try
            {
                SetActionStatus(false);
                SetAbortStatus(true);
                _ExtractRunning = true;
                _MainForm.SetTableLayoutMainStatus(false);
                _TotalJobs = argJobInfoList.Count;
                _CurrentJob = 0;
                prgBrTotal.Maximum = _TotalJobs * 100;
                RunJobs(new List<gMKVJobInfo>(argJobInfoList));
                // Check exception builder for exceptions
                if (_ExceptionBuilder.Length > 0)
                {
                    // reset the status from pending to ready
                    foreach (DataGridViewRow item in grdJobs.Rows)
                    {
                        gMKVJobInfo jobInfo = (gMKVJobInfo)item.DataBoundItem;
                        if (jobInfo.State == JobState.Pending)
                        {
                            jobInfo.State = JobState.Ready;
                        }
                    }
                    throw new Exception(_ExceptionBuilder.ToString());
                }
                UpdateCurrentProgress(100);
                if (chkShowPopup.Checked)
                {
                    ShowSuccessMessage("The jobs completed successfully!");
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
            finally
            {
                if (chkShowPopup.Checked || exceptionOccured)
                {
                    UpdateCurrentProgress(0);
                    prgBrTotal.Value = 0;
                    lblCurrentProgressValue.Text = "";
                    lblTotalProgressValue.Text = "";
                }
                else
                {
                    lblCurrentProgressValue.Text = "";
                    lblTotalProgressValue.Text = "";
                    txtCurrentTrack.Text = "Extraction completed!";
                }
                gTaskbarProgress.SetState(this, gTaskbarProgress.TaskbarStates.NoProgress);
                gTaskbarProgress.SetOverlayIcon(this, null, null);
                _ExtractRunning = false;
                _AbortAll = false;
                grdJobs.Refresh();
                SetActionStatus(true);
                SetAbortStatus(false);
                _MainForm.SetTableLayoutMainStatus(true);
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            try
            {
                if (_gMkvExtract != null)
                {
                    _gMkvExtract.Abort = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnAbortAll_Click(object sender, EventArgs e)
        {
            try
            {
                _AbortAll = true;
                if (_gMkvExtract != null)
                {
                    _gMkvExtract.Abort = true;
                    _gMkvExtract.AbortAll = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private Int32 GetNumberOfJobs(JobState argState)
        {
            Int32 counter = 0;
            foreach (DataGridViewRow drJobInfo in grdJobs.Rows)
            {
                gMKVJobInfo jobInfo = (gMKVJobInfo)drJobInfo.DataBoundItem;
                if (jobInfo.State == argState)
                {
                    counter++;
                }
            }
            return counter;
        }

        private void grdJobs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the row clicked is selected
                if (grdJobs.Rows[e.RowIndex].Selected)
                {
                    gMKVJobInfo jobInfo = (gMKVJobInfo)grdJobs.Rows[e.RowIndex].DataBoundItem;
                    if (jobInfo.State == JobState.Failed || jobInfo.State == JobState.Completed)
                    {
                        jobInfo.Reset();
                        grdJobs.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void btnSaveJobs_Click(object sender, EventArgs e)
        {
            try
            {
                // ask for path
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select job file...";
                sfd.InitialDirectory = GetCurrentDirectory();
                sfd.Filter = "*.xml|*.xml";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<gMKVJobInfo>));
                        
                        List<gMKVJobInfo> jobList = new List<gMKVJobInfo>();
                        foreach (DataGridViewRow item in grdJobs.Rows)
                        {
                            jobList.Add((gMKVJobInfo)item.DataBoundItem);
                        }

                        x.Serialize(sw, jobList);
                    }
                    ShowSuccessMessage("The jobs were save successfully!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnLoadJobs_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask for path
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = GetCurrentDirectory();
                ofd.Title = "Select jobs file...";
                ofd.Filter = "*.xml|*.xml";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    List<gMKVJobInfo> jobList = null;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                    {
                        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<gMKVJobInfo>));
                        
                        jobList = (List<gMKVJobInfo>)x.Deserialize(sr);
                    }
                    SetJobsList(new BindingList<gMKVJobInfo>(jobList));
                    ShowSuccessMessage("The jobs were loaded successfully!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            SetContextMenuText();
        }

        private void SetContextMenuText()
        {
            if (_ExtractRunning)
            {
                changeToReadyStatusToolStripMenuItem.Enabled = false;
            }
            else if (grdJobs.SelectedRows.Count == 0)
            {
                changeToReadyStatusToolStripMenuItem.Enabled = false;
            }
            else
            {
                foreach (DataGridViewRow row in grdJobs.SelectedRows)
                {
                    if(((gMKVJobInfo)row.DataBoundItem).State != JobState.Ready)
                    {
                        changeToReadyStatusToolStripMenuItem.Enabled = true;
                        break;
                    }
                }
            }
        }

        private void changeToReadyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdJobs.SelectedRows)
            {
                if (((gMKVJobInfo)row.DataBoundItem).State != JobState.Ready)
                {
                    ((gMKVJobInfo)row.DataBoundItem).Reset();
                }
            }
            grdJobs.Refresh();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdJobs.ClearSelection();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdJobs.SelectAll();
        }

        private void chkShowPopup_CheckedChanged(object sender, EventArgs e)
        {
            if (!_FromConstructor)
            {
                _Settings.ShowPopupInJobManager = chkShowPopup.Checked;
                _Settings.Save();
            }
        }

        private void grdJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                grpJobs.Text = String.Format("Jobs ({0})", grdJobs.Rows.Count);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                gMKVLogger.Log(ex.ToString());
                ShowErrorMessage(ex.Message);
            }
        }
    }
}
