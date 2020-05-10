using osu__map_status_by_Maulenko.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowTitleWatcher;
using WindowTitleWatcher.Util;

namespace osu__map_status_by_Maulenko
{
    public partial class MapStatus : Form
    {
        SettingsForm settingsForm;
        HelpForm helpForm;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public MapStatus()
        {
            InitializeComponent();
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (settingsForm.api.IsAuthorized)
                    {
                        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                        LabelStatusActive.Text = "Activated";
                        while (LabelStatusActive.Text == "Activated")
                        {
                            NowPlaying();
                            settingsForm.StatusChange();
                            Thread.Sleep(30000);
                        }
                    }
                    else
                        MessageBox.Show("Failed to connect.");
                }
                catch
                {
                    MessageBox.Show("Failed to connect.");
                }
                
            });
            
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {

                    if (LabelStatusActive.Text == "Activated")
                    {
                        settingsForm.StatusStop();
                        LabelStatusActive.Text = "Not activated";
                        LabelNowPlaying.Text = "Now Playing:";
                    }
                    else
                        MessageBox.Show("Nothing not found");
                }
                catch
                {
                    MessageBox.Show("Nothing not found");
                }
            });
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this);
            settingsForm.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm(this);
            helpForm.Visible = true;
        }
        public void NowPlaying()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            WindowInfo window = Windows.FindFirst(w => w.IsVisible && w.ProcessName == "osu!");
            if (window != null)
            {
                BasicWatcher watcher = new BasicWatcher(window);
                LabelNowPlaying.Text = $"Now Playing: \n{watcher.Title}";
                LabelStatusActive.Text = "Activated";
            }
            else
            {
                MessageBox.Show("Not finded osu!");
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void FormName_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void FormName_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void FormName_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void MapStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                settingsForm.StatusStop();
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
