using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private class PreviewText
        {
            public TextBox textBox;

            private void onClick_CALLBACK(object sender, EventArgs args)
            {
                this.textBox.Clear();
                this.textBox.ForeColor = Color.FromArgb(255, 255, 255);
            }

            private void onKeyEnter_CALLBACK(object sender, KeyEventArgs args)
            {
                if (args.KeyCode == Keys.Enter) {
                    this.textBox.ForeColor = Color.FromArgb(150, 150, 150);
                    this.textBox.Enabled = false;
                    this.textBox.Enabled = true;
                }
            }

            public PreviewText(TextBox box)
            {
                this.textBox = box;
                this.textBox.MouseClick += new MouseEventHandler(onClick_CALLBACK);
                this.textBox.KeyDown += new KeyEventHandler(onKeyEnter_CALLBACK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new PreviewText(this.FpsValue);
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

        private int fpsValue = 10000;

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
                File.WriteAllText(info.FullName + "/ClientAppSettings.json", "{\r\n            \"DFIntTaskSchedulerTargetFps\": "+fpsValue+",\r\n            \"FFlagReportFpsAndGfxQualityPercentiles\": false\r\n         }");
                this.CurrentPath.Text = "Successfully created!";
            } else {
                this.CurrentPath.Text = "Fps unlocker already exist!";
            }
        }

        private void deleteClientSettings(String rbxPath) {
            if (Directory.Exists(rbxPath + "/ClientSettings")) {
                // deletes all the files
                foreach (String fpath in Directory.GetFiles(rbxPath + "/ClientSettings")) {
                    File.Delete(fpath);
                }

                Directory.Delete(rbxPath + "/ClientSettings");
                this.CurrentPath.Text = "Successfully deleted!";
            } else {
                this.CurrentPath.Text = "Fps unlocker doesn't exist!";
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

        private void FpsValue_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                fpsValue = Int32.Parse(FpsValue.Text);
                if (Int32.Parse(FpsValue.Text) != 0) {
                    this.CurrentPath.Text = "Changed the current FPS value!";
                }
            } catch (Exception ex)
            {
                this.CurrentPath.Text = "Not a valid FPS value!";
            }
        }

        private void DeleteFpsUnlocker_Click(object sender, EventArgs e)
        {
            if (robloxPath != "" || robloxPath != null) {
                deleteClientSettings(robloxPath);
            }
        }
    }
}
