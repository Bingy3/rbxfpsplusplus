using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rbxfpsplus_II
{
    public partial class RBXFPSPlus : Form
    {
        public RBXFPSPlus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // dragging

        private Point lastLoc;
        private bool mouseDown;

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLoc = e.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) { 
                this.Location = new Point((this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y);
                this.Update();
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // fps unlocker stuff

        private String robloxPath;
        private String customPath;

        private String getRobloxPath(String _path) {
            String path = "";
            if (Directory.Exists(_path + "/Versions")) {
                foreach (String __path in Directory.GetDirectories(_path + "/Versions")) {
                    if (File.Exists(__path + "/RobloxPlayerBeta.exe")) {
                        path = __path;
                    }
                }
            }
            return path;
        }

        /* json
         
         {
            "DFIntTaskSchedulerTargetFps": 10000,
            "FFlagReportFpsAndGfxQualityPercentiles": false
         }
         
         */

        private void createClientSettings(String rbxPath) {
            if (!Directory.Exists(rbxPath + "/ClientSettings")) {
                DirectoryInfo info = Directory.CreateDirectory(rbxPath + "/ClientSettings");
                File.Create(info.FullName + "/ClientAppSettings.json").Close();
                // writing to the file
                File.WriteAllText(info.FullName + "/ClientAppSettings.json", "{\r\n            \"DFIntTaskSchedulerTargetFps\": 10000,\r\n            \"FFlagReportFpsAndGfxQualityPercentiles\": false\r\n         }");
            } else {
                this.CurrentPath.Text = "Fps unlocker already exist!";
            }
        }

        private void GetRobloxPath_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Directory.GetParent(path).FullName;
            if (Directory.Exists(path + "/Local"))
            {
                path = path + "/Local";
                if (Directory.Exists(path + "/Roblox"))
                {
                    path = path + "/Roblox";
                    robloxPath = getRobloxPath(path);
                    if (robloxPath == "") { this.CurrentPath.Text = "Cannot find version folder!"; return; }
                    this.CurrentPath.Text = robloxPath;
                }
                else
                {
                    this.CurrentPath.Text = "Roblox doesn't exist!";
                }
            } else {
                this.CurrentPath.Text = "Cannot find /Local folder!";
            }   
        }

        private void GenFpsUnlocker_Click(object sender, EventArgs e)
        {
            if (robloxPath != "" || robloxPath != null) { 
                createClientSettings(robloxPath);
            }
        }

        private void CustomPath_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            fileDialog.InitialDirectory = Directory.GetParent(fileDialog.InitialDirectory).FullName;
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK) { 
                customPath = Directory.GetParent(fileDialog.FileName).FullName;
                this.CurrentPath.Text = customPath;
            }
        }
    }
}
