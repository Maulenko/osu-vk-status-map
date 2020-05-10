using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VkNet;
using VkNet.Model;
using System.Diagnostics;
using WindowTitleWatcher;
using WindowTitleWatcher.Util;

namespace osu__map_status_by_Maulenko
{
    public partial class SettingsForm : Form
    {
        MapStatus parent;
        public VkApi api;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public SettingsForm(MapStatus mapStatus)
        {
            InitializeComponent();
            parent = mapStatus;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnAddAPI_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                ApiSave();
            }
            ApiAuth(textBoxApiAdd.Text);
            this.Close();
        }
        public void ApiAuth(string token)
        {
            api = new VkApi();

            api.Authorize(new ApiAuthParams
            {
                AccessToken = token
            });
        }

        public void ApiSave()
        {
            
            File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\API.txt", textBoxApiAdd.Text);
        }
        

        public async void StatusChange()
        {
            WindowInfo window = Windows.FindFirst(w => w.IsVisible && w.ProcessName == "osu!");
            await Task.Run(() =>
            {
                
                if (window != null)
                {
                    if (window.Title != "osu!")
                    {
                        BasicWatcher watcher = new BasicWatcher(window);
                        string statusosumap = watcher.Title;
                        api.Status.SetAsync(statusosumap);
                    }
                    else
                        api.Status.SetAsync("Selecting the map");
                }
                else
                {
                    MessageBox.Show("Not finded osu!");
                }
            });
        }
        public void StatusStop()
        {
            try
            {
                if (api.IsAuthorized)
                    api.Status.SetAsync("");
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Failed to stop.");
            }
        }

        private void ImportAPI_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\API.txt"))
            {
                if (MessageBox.Show($"API has been saved.\nWant to download it?", "API was discovered", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string authapi = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\API.txt");
                    ApiAuth(authapi);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Enter the new API.");
                }

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

        private void FormSetting_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void FormSetting_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void FormSetting_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
