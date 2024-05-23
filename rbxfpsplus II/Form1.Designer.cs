namespace rbxfpsplus_II
{
    partial class RBXFPSPlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBXFPSPlus));
            this.Title = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CurrentPath = new System.Windows.Forms.Label();
            this.GetRobloxPath = new System.Windows.Forms.Button();
            this.GenFpsUnlocker = new System.Windows.Forms.Button();
            this.CustomPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FpsValue = new System.Windows.Forms.TextBox();
            this.DeleteFpsUnlocker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "RBXFPS+";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ExitButton.Location = new System.Drawing.Point(741, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 58);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.Location = new System.Drawing.Point(6, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(791, 67);
            this.DragPanel.TabIndex = 2;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinimizeButton.Location = new System.Drawing.Point(689, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(56, 58);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CurrentPath
            // 
            this.CurrentPath.AutoSize = true;
            this.CurrentPath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPath.ForeColor = System.Drawing.Color.White;
            this.CurrentPath.Location = new System.Drawing.Point(12, 307);
            this.CurrentPath.Name = "CurrentPath";
            this.CurrentPath.Size = new System.Drawing.Size(82, 28);
            this.CurrentPath.TabIndex = 4;
            this.CurrentPath.Text = "Status...";
            // 
            // GetRobloxPath
            // 
            this.GetRobloxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GetRobloxPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GetRobloxPath.FlatAppearance.BorderSize = 0;
            this.GetRobloxPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetRobloxPath.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRobloxPath.ForeColor = System.Drawing.Color.White;
            this.GetRobloxPath.Location = new System.Drawing.Point(274, 113);
            this.GetRobloxPath.Name = "GetRobloxPath";
            this.GetRobloxPath.Size = new System.Drawing.Size(271, 49);
            this.GetRobloxPath.TabIndex = 5;
            this.GetRobloxPath.Text = "Get roblox path";
            this.GetRobloxPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetRobloxPath.UseVisualStyleBackColor = false;
            this.GetRobloxPath.Click += new System.EventHandler(this.GetRobloxPath_Click);
            // 
            // GenFpsUnlocker
            // 
            this.GenFpsUnlocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GenFpsUnlocker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GenFpsUnlocker.FlatAppearance.BorderSize = 0;
            this.GenFpsUnlocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenFpsUnlocker.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenFpsUnlocker.ForeColor = System.Drawing.Color.White;
            this.GenFpsUnlocker.Location = new System.Drawing.Point(226, 178);
            this.GenFpsUnlocker.Name = "GenFpsUnlocker";
            this.GenFpsUnlocker.Size = new System.Drawing.Size(371, 49);
            this.GenFpsUnlocker.TabIndex = 6;
            this.GenFpsUnlocker.Text = "Generate fps unlocker";
            this.GenFpsUnlocker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GenFpsUnlocker.UseVisualStyleBackColor = false;
            this.GenFpsUnlocker.Click += new System.EventHandler(this.GenFpsUnlocker_Click);
            // 
            // CustomPath
            // 
            this.CustomPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomPath.FlatAppearance.BorderSize = 0;
            this.CustomPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomPath.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPath.ForeColor = System.Drawing.Color.White;
            this.CustomPath.Location = new System.Drawing.Point(274, 249);
            this.CustomPath.Name = "CustomPath";
            this.CustomPath.Size = new System.Drawing.Size(271, 49);
            this.CustomPath.TabIndex = 7;
            this.CustomPath.Text = "Custom path";
            this.CustomPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CustomPath.UseVisualStyleBackColor = false;
            this.CustomPath.Click += new System.EventHandler(this.CustomPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Made by Bingy3 (@AG_FROP on roblox)";
            // 
            // FpsValue
            // 
            this.FpsValue.AccessibleDescription = "";
            this.FpsValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FpsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FpsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FpsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FpsValue.Location = new System.Drawing.Point(17, 154);
            this.FpsValue.Name = "FpsValue";
            this.FpsValue.Size = new System.Drawing.Size(141, 36);
            this.FpsValue.TabIndex = 9;
            this.FpsValue.Text = "Fps...";
            this.FpsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FpsValue.TextChanged += new System.EventHandler(this.FpsValue_TextChanged);
            // 
            // DeleteFpsUnlocker
            // 
            this.DeleteFpsUnlocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteFpsUnlocker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteFpsUnlocker.FlatAppearance.BorderSize = 0;
            this.DeleteFpsUnlocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFpsUnlocker.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.DeleteFpsUnlocker.ForeColor = System.Drawing.Color.White;
            this.DeleteFpsUnlocker.Location = new System.Drawing.Point(17, 196);
            this.DeleteFpsUnlocker.Name = "DeleteFpsUnlocker";
            this.DeleteFpsUnlocker.Size = new System.Drawing.Size(182, 29);
            this.DeleteFpsUnlocker.TabIndex = 10;
            this.DeleteFpsUnlocker.Text = "Delete fps unlocker";
            this.DeleteFpsUnlocker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteFpsUnlocker.UseVisualStyleBackColor = false;
            this.DeleteFpsUnlocker.Click += new System.EventHandler(this.DeleteFpsUnlocker_Click);
            // 
            // RBXFPSPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.DeleteFpsUnlocker);
            this.Controls.Add(this.FpsValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomPath);
            this.Controls.Add(this.GenFpsUnlocker);
            this.Controls.Add(this.GetRobloxPath);
            this.Controls.Add(this.CurrentPath);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RBXFPSPlus";
            this.Text = "RBXFPSPlus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label CurrentPath;
        private System.Windows.Forms.Button GetRobloxPath;
        private System.Windows.Forms.Button GenFpsUnlocker;
        private System.Windows.Forms.Button CustomPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FpsValue;
        private System.Windows.Forms.Button DeleteFpsUnlocker;
    }
}

