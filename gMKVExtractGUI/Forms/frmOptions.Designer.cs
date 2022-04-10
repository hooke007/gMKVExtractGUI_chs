namespace gMKVToolNix.Forms
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new gMKVToolNix.gTableLayoutPanel();
            this.grpChapters = new gMKVToolNix.gGroupBox();
            this.btnDefaultChapterPlaceholder = new System.Windows.Forms.Button();
            this.btnAddChapterPlaceholder = new System.Windows.Forms.Button();
            this.txtChaptersFilename = new gMKVToolNix.gTextBox();
            this.grpActions = new gMKVToolNix.gGroupBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpVideoTracks = new gMKVToolNix.gGroupBox();
            this.btnDefaultVideoTrackPlaceholder = new System.Windows.Forms.Button();
            this.btnAddVideoTrackPlaceholder = new System.Windows.Forms.Button();
            this.txtVideoTracksFilename = new gMKVToolNix.gTextBox();
            this.grpAudioTracks = new gMKVToolNix.gGroupBox();
            this.btnDefaultAudioTrackPlaceholder = new System.Windows.Forms.Button();
            this.btnAddAudioTrackPlaceholder = new System.Windows.Forms.Button();
            this.txtAudioTracksFilename = new gMKVToolNix.gTextBox();
            this.grpSubtitleTracks = new gMKVToolNix.gGroupBox();
            this.btnDefaultSubtitleTrackPlaceholder = new System.Windows.Forms.Button();
            this.btnAddSubtitleTrackPlaceholder = new System.Windows.Forms.Button();
            this.txtSubtitleTracksFilename = new gMKVToolNix.gTextBox();
            this.grpAttachments = new gMKVToolNix.gGroupBox();
            this.btnDefaultAttachmentPlaceholder = new System.Windows.Forms.Button();
            this.btnAddAttachmentPlaceholder = new System.Windows.Forms.Button();
            this.txtAttachmentsFilename = new gMKVToolNix.gTextBox();
            this.grpInfo = new gMKVToolNix.gGroupBox();
            this.txtInfo = new gMKVToolNix.gRichTextBox();
            this.tlpMain.SuspendLayout();
            this.grpChapters.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpVideoTracks.SuspendLayout();
            this.grpAudioTracks.SuspendLayout();
            this.grpSubtitleTracks.SuspendLayout();
            this.grpAttachments.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpChapters, 0, 4);
            this.tlpMain.Controls.Add(this.grpActions, 0, 6);
            this.tlpMain.Controls.Add(this.grpVideoTracks, 0, 1);
            this.tlpMain.Controls.Add(this.grpAudioTracks, 0, 2);
            this.tlpMain.Controls.Add(this.grpSubtitleTracks, 0, 3);
            this.tlpMain.Controls.Add(this.grpAttachments, 0, 5);
            this.tlpMain.Controls.Add(this.grpInfo, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(654, 481);
            this.tlpMain.TabIndex = 0;
            // 
            // grpChapters
            // 
            this.grpChapters.Controls.Add(this.btnDefaultChapterPlaceholder);
            this.grpChapters.Controls.Add(this.btnAddChapterPlaceholder);
            this.grpChapters.Controls.Add(this.txtChaptersFilename);
            this.grpChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChapters.Location = new System.Drawing.Point(3, 334);
            this.grpChapters.Name = "grpChapters";
            this.grpChapters.Size = new System.Drawing.Size(619, 54);
            this.grpChapters.TabIndex = 0;
            this.grpChapters.TabStop = false;
            this.grpChapters.Text = "Chapters";
            // 
            // btnDefaultChapterPlaceholder
            // 
            this.btnDefaultChapterPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultChapterPlaceholder.Location = new System.Drawing.Point(533, 16);
            this.btnDefaultChapterPlaceholder.Name = "btnDefaultChapterPlaceholder";
            this.btnDefaultChapterPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnDefaultChapterPlaceholder.TabIndex = 5;
            this.btnDefaultChapterPlaceholder.Text = "Default";
            this.btnDefaultChapterPlaceholder.UseVisualStyleBackColor = true;
            this.btnDefaultChapterPlaceholder.Click += new System.EventHandler(this.btnDefaultChapterPlaceholder_Click);
            // 
            // btnAddChapterPlaceholder
            // 
            this.btnAddChapterPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChapterPlaceholder.Location = new System.Drawing.Point(447, 16);
            this.btnAddChapterPlaceholder.Name = "btnAddChapterPlaceholder";
            this.btnAddChapterPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnAddChapterPlaceholder.TabIndex = 4;
            this.btnAddChapterPlaceholder.Text = "Add...";
            this.btnAddChapterPlaceholder.UseVisualStyleBackColor = true;
            this.btnAddChapterPlaceholder.Click += new System.EventHandler(this.btnAddChapterPlaceholder_Click);
            // 
            // txtChaptersFilename
            // 
            this.txtChaptersFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChaptersFilename.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtChaptersFilename.Location = new System.Drawing.Point(9, 20);
            this.txtChaptersFilename.Name = "txtChaptersFilename";
            this.txtChaptersFilename.Size = new System.Drawing.Size(433, 23);
            this.txtChaptersFilename.TabIndex = 1;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnDefaults);
            this.grpActions.Controls.Add(this.btnOK);
            this.grpActions.Controls.Add(this.btnCancel);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActions.Location = new System.Drawing.Point(3, 454);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(619, 54);
            this.grpActions.TabIndex = 0;
            this.grpActions.TabStop = false;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(9, 17);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(83, 30);
            this.btnDefaults.TabIndex = 6;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(447, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(533, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpVideoTracks
            // 
            this.grpVideoTracks.Controls.Add(this.btnDefaultVideoTrackPlaceholder);
            this.grpVideoTracks.Controls.Add(this.btnAddVideoTrackPlaceholder);
            this.grpVideoTracks.Controls.Add(this.txtVideoTracksFilename);
            this.grpVideoTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVideoTracks.Location = new System.Drawing.Point(3, 154);
            this.grpVideoTracks.Name = "grpVideoTracks";
            this.grpVideoTracks.Size = new System.Drawing.Size(619, 54);
            this.grpVideoTracks.TabIndex = 1;
            this.grpVideoTracks.TabStop = false;
            this.grpVideoTracks.Text = "Video Tracks";
            // 
            // btnDefaultVideoTrackPlaceholder
            // 
            this.btnDefaultVideoTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultVideoTrackPlaceholder.Location = new System.Drawing.Point(533, 18);
            this.btnDefaultVideoTrackPlaceholder.Name = "btnDefaultVideoTrackPlaceholder";
            this.btnDefaultVideoTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnDefaultVideoTrackPlaceholder.TabIndex = 2;
            this.btnDefaultVideoTrackPlaceholder.Text = "Default";
            this.btnDefaultVideoTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnDefaultVideoTrackPlaceholder.Click += new System.EventHandler(this.btnDefaultVideoTrackPlaceholder_Click);
            // 
            // btnAddVideoTrackPlaceholder
            // 
            this.btnAddVideoTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVideoTrackPlaceholder.Location = new System.Drawing.Point(447, 18);
            this.btnAddVideoTrackPlaceholder.Name = "btnAddVideoTrackPlaceholder";
            this.btnAddVideoTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnAddVideoTrackPlaceholder.TabIndex = 1;
            this.btnAddVideoTrackPlaceholder.Text = "Add...";
            this.btnAddVideoTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnAddVideoTrackPlaceholder.Click += new System.EventHandler(this.btnAddVideoTrackPlaceholder_Click);
            // 
            // txtVideoTracksFilename
            // 
            this.txtVideoTracksFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoTracksFilename.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtVideoTracksFilename.Location = new System.Drawing.Point(9, 22);
            this.txtVideoTracksFilename.Name = "txtVideoTracksFilename";
            this.txtVideoTracksFilename.Size = new System.Drawing.Size(433, 23);
            this.txtVideoTracksFilename.TabIndex = 0;
            // 
            // grpAudioTracks
            // 
            this.grpAudioTracks.Controls.Add(this.btnDefaultAudioTrackPlaceholder);
            this.grpAudioTracks.Controls.Add(this.btnAddAudioTrackPlaceholder);
            this.grpAudioTracks.Controls.Add(this.txtAudioTracksFilename);
            this.grpAudioTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAudioTracks.Location = new System.Drawing.Point(3, 214);
            this.grpAudioTracks.Name = "grpAudioTracks";
            this.grpAudioTracks.Size = new System.Drawing.Size(619, 54);
            this.grpAudioTracks.TabIndex = 2;
            this.grpAudioTracks.TabStop = false;
            this.grpAudioTracks.Text = "Audio Tracks";
            // 
            // btnDefaultAudioTrackPlaceholder
            // 
            this.btnDefaultAudioTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultAudioTrackPlaceholder.Location = new System.Drawing.Point(533, 18);
            this.btnDefaultAudioTrackPlaceholder.Name = "btnDefaultAudioTrackPlaceholder";
            this.btnDefaultAudioTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnDefaultAudioTrackPlaceholder.TabIndex = 3;
            this.btnDefaultAudioTrackPlaceholder.Text = "Default";
            this.btnDefaultAudioTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnDefaultAudioTrackPlaceholder.Click += new System.EventHandler(this.btnDefaultAudioTrackPlaceholder_Click);
            // 
            // btnAddAudioTrackPlaceholder
            // 
            this.btnAddAudioTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAudioTrackPlaceholder.Location = new System.Drawing.Point(447, 18);
            this.btnAddAudioTrackPlaceholder.Name = "btnAddAudioTrackPlaceholder";
            this.btnAddAudioTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnAddAudioTrackPlaceholder.TabIndex = 2;
            this.btnAddAudioTrackPlaceholder.Text = "Add...";
            this.btnAddAudioTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnAddAudioTrackPlaceholder.Click += new System.EventHandler(this.btnAddAudioTrackPlaceholder_Click);
            // 
            // txtAudioTracksFilename
            // 
            this.txtAudioTracksFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAudioTracksFilename.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAudioTracksFilename.Location = new System.Drawing.Point(9, 22);
            this.txtAudioTracksFilename.Name = "txtAudioTracksFilename";
            this.txtAudioTracksFilename.Size = new System.Drawing.Size(433, 23);
            this.txtAudioTracksFilename.TabIndex = 1;
            // 
            // grpSubtitleTracks
            // 
            this.grpSubtitleTracks.Controls.Add(this.btnDefaultSubtitleTrackPlaceholder);
            this.grpSubtitleTracks.Controls.Add(this.btnAddSubtitleTrackPlaceholder);
            this.grpSubtitleTracks.Controls.Add(this.txtSubtitleTracksFilename);
            this.grpSubtitleTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSubtitleTracks.Location = new System.Drawing.Point(3, 274);
            this.grpSubtitleTracks.Name = "grpSubtitleTracks";
            this.grpSubtitleTracks.Size = new System.Drawing.Size(619, 54);
            this.grpSubtitleTracks.TabIndex = 3;
            this.grpSubtitleTracks.TabStop = false;
            this.grpSubtitleTracks.Text = "Subtitle Tracks";
            // 
            // btnDefaultSubtitleTrackPlaceholder
            // 
            this.btnDefaultSubtitleTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultSubtitleTrackPlaceholder.Location = new System.Drawing.Point(533, 18);
            this.btnDefaultSubtitleTrackPlaceholder.Name = "btnDefaultSubtitleTrackPlaceholder";
            this.btnDefaultSubtitleTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnDefaultSubtitleTrackPlaceholder.TabIndex = 4;
            this.btnDefaultSubtitleTrackPlaceholder.Text = "Default";
            this.btnDefaultSubtitleTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnDefaultSubtitleTrackPlaceholder.Click += new System.EventHandler(this.btnDefaultSubtitleTrackPlaceholder_Click);
            // 
            // btnAddSubtitleTrackPlaceholder
            // 
            this.btnAddSubtitleTrackPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubtitleTrackPlaceholder.Location = new System.Drawing.Point(447, 18);
            this.btnAddSubtitleTrackPlaceholder.Name = "btnAddSubtitleTrackPlaceholder";
            this.btnAddSubtitleTrackPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnAddSubtitleTrackPlaceholder.TabIndex = 3;
            this.btnAddSubtitleTrackPlaceholder.Text = "Add...";
            this.btnAddSubtitleTrackPlaceholder.UseVisualStyleBackColor = true;
            this.btnAddSubtitleTrackPlaceholder.Click += new System.EventHandler(this.btnAddSubtitleTrackPlaceholder_Click);
            // 
            // txtSubtitleTracksFilename
            // 
            this.txtSubtitleTracksFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtitleTracksFilename.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtSubtitleTracksFilename.Location = new System.Drawing.Point(9, 22);
            this.txtSubtitleTracksFilename.Name = "txtSubtitleTracksFilename";
            this.txtSubtitleTracksFilename.Size = new System.Drawing.Size(433, 23);
            this.txtSubtitleTracksFilename.TabIndex = 1;
            // 
            // grpAttachments
            // 
            this.grpAttachments.Controls.Add(this.btnDefaultAttachmentPlaceholder);
            this.grpAttachments.Controls.Add(this.btnAddAttachmentPlaceholder);
            this.grpAttachments.Controls.Add(this.txtAttachmentsFilename);
            this.grpAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAttachments.Location = new System.Drawing.Point(3, 394);
            this.grpAttachments.Name = "grpAttachments";
            this.grpAttachments.Size = new System.Drawing.Size(619, 54);
            this.grpAttachments.TabIndex = 4;
            this.grpAttachments.TabStop = false;
            this.grpAttachments.Text = "Attachments";
            // 
            // btnDefaultAttachmentPlaceholder
            // 
            this.btnDefaultAttachmentPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultAttachmentPlaceholder.Location = new System.Drawing.Point(533, 19);
            this.btnDefaultAttachmentPlaceholder.Name = "btnDefaultAttachmentPlaceholder";
            this.btnDefaultAttachmentPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnDefaultAttachmentPlaceholder.TabIndex = 6;
            this.btnDefaultAttachmentPlaceholder.Text = "Default";
            this.btnDefaultAttachmentPlaceholder.UseVisualStyleBackColor = true;
            this.btnDefaultAttachmentPlaceholder.Click += new System.EventHandler(this.btnDefaultAttachmentPlaceholder_Click);
            // 
            // btnAddAttachmentPlaceholder
            // 
            this.btnAddAttachmentPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAttachmentPlaceholder.Location = new System.Drawing.Point(447, 19);
            this.btnAddAttachmentPlaceholder.Name = "btnAddAttachmentPlaceholder";
            this.btnAddAttachmentPlaceholder.Size = new System.Drawing.Size(83, 30);
            this.btnAddAttachmentPlaceholder.TabIndex = 5;
            this.btnAddAttachmentPlaceholder.Text = "Add...";
            this.btnAddAttachmentPlaceholder.UseVisualStyleBackColor = true;
            this.btnAddAttachmentPlaceholder.Click += new System.EventHandler(this.btnAddAttachmentPlaceholder_Click);
            // 
            // txtAttachmentsFilename
            // 
            this.txtAttachmentsFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAttachmentsFilename.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAttachmentsFilename.Location = new System.Drawing.Point(9, 23);
            this.txtAttachmentsFilename.Name = "txtAttachmentsFilename";
            this.txtAttachmentsFilename.Size = new System.Drawing.Size(433, 23);
            this.txtAttachmentsFilename.TabIndex = 1;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtInfo);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(619, 145);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // txtInfo
            // 
            this.txtInfo.DetectUrls = false;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 19);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ShortcutsEnabled = false;
            this.txtInfo.Size = new System.Drawing.Size(613, 123);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // frmOptions
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 481);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tlpMain.ResumeLayout(false);
            this.grpChapters.ResumeLayout(false);
            this.grpChapters.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpVideoTracks.ResumeLayout(false);
            this.grpVideoTracks.PerformLayout();
            this.grpAudioTracks.ResumeLayout(false);
            this.grpAudioTracks.PerformLayout();
            this.grpSubtitleTracks.ResumeLayout(false);
            this.grpSubtitleTracks.PerformLayout();
            this.grpAttachments.ResumeLayout(false);
            this.grpAttachments.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private gTableLayoutPanel tlpMain;
        private gGroupBox grpActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private gGroupBox grpVideoTracks;
        private gGroupBox grpChapters;
        private gTextBox txtChaptersFilename;
        private gTextBox txtVideoTracksFilename;
        private gGroupBox grpAudioTracks;
        private gTextBox txtAudioTracksFilename;
        private gGroupBox grpSubtitleTracks;
        private gTextBox txtSubtitleTracksFilename;
        private gGroupBox grpAttachments;
        private gTextBox txtAttachmentsFilename;
        private System.Windows.Forms.Button btnAddVideoTrackPlaceholder;
        private System.Windows.Forms.Button btnAddChapterPlaceholder;
        private System.Windows.Forms.Button btnAddAudioTrackPlaceholder;
        private System.Windows.Forms.Button btnAddSubtitleTrackPlaceholder;
        private System.Windows.Forms.Button btnAddAttachmentPlaceholder;
        private gGroupBox grpInfo;
        private gRichTextBox txtInfo;
        private System.Windows.Forms.Button btnDefaultChapterPlaceholder;
        private System.Windows.Forms.Button btnDefaultVideoTrackPlaceholder;
        private System.Windows.Forms.Button btnDefaultAudioTrackPlaceholder;
        private System.Windows.Forms.Button btnDefaultSubtitleTrackPlaceholder;
        private System.Windows.Forms.Button btnDefaultAttachmentPlaceholder;
        private System.Windows.Forms.Button btnDefaults;
    }
}
