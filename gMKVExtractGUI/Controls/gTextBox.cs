using gMKVToolNix.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace gMKVToolNix
{
    public class gTextBox:TextBox
    {
        public gTextBox()
            : base()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            try
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    this.SelectAll();
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    if (!String.IsNullOrWhiteSpace(this.SelectedText))
                    {
                        Clipboard.SetText(this.SelectedText, TextDataFormat.UnicodeText);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                ex.ShowException();
            }
        }
    }
}
