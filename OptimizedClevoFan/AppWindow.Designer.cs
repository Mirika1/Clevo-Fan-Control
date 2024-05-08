namespace OptimizedClevoFan
{
    partial class AppWindow
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
            this.components = new System.ComponentModel.Container();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.offsetTrackBar = new System.Windows.Forms.TrackBar();
            this.offsetValue = new System.Windows.Forms.Label();
            this.panelFanInfos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fanModes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Preset_1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preset_2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Preset_3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Preset_4ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Preset_5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preset_6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGeneralInfos = new System.Windows.Forms.Button();
            this.checkBoxStartWithWindows = new System.Windows.Forms.CheckBox();
            this.stepLbl = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOffset = new System.Windows.Forms.Button();
            this.savePresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preset1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fanModes.SuspendLayout();
            this.savePresets.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIconDoubleClick);
            // 
            // offsetTrackBar
            // 
            this.offsetTrackBar.AutoSize = false;
            this.offsetTrackBar.BackColor = System.Drawing.Color.White;
            this.offsetTrackBar.Location = new System.Drawing.Point(1071, 44);
            this.offsetTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.offsetTrackBar.Maximum = 25;
            this.offsetTrackBar.Name = "offsetTrackBar";
            this.offsetTrackBar.Size = new System.Drawing.Size(251, 42);
            this.offsetTrackBar.TabIndex = 0;
            this.offsetTrackBar.Scroll += new System.EventHandler(this.offsetTrackBar_Scroll);
            // 
            // offsetValue
            // 
            this.offsetValue.AutoSize = true;
            this.offsetValue.BackColor = System.Drawing.Color.White;
            this.offsetValue.Location = new System.Drawing.Point(1332, 49);
            this.offsetValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offsetValue.Name = "offsetValue";
            this.offsetValue.Size = new System.Drawing.Size(26, 16);
            this.offsetValue.TabIndex = 1;
            this.offsetValue.Text = "0%";
            // 
            // panelFanInfos
            // 
            this.panelFanInfos.AutoScroll = true;
            this.panelFanInfos.Location = new System.Drawing.Point(8, 114);
            this.panelFanInfos.Margin = new System.Windows.Forms.Padding(4);
            this.panelFanInfos.Name = "panelFanInfos";
            this.panelFanInfos.Size = new System.Drawing.Size(1362, 623);
            this.panelFanInfos.TabIndex = 6;
            this.panelFanInfos.WrapContents = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Location = new System.Drawing.Point(295, 744);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(229, 28);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save Configuration";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Location = new System.Drawing.Point(1124, 744);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(229, 28);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Location = new System.Drawing.Point(572, 744);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(229, 28);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close Window";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.White;
            this.buttonLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLoad.Location = new System.Drawing.Point(19, 744);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(229, 28);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Load Configuration";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click_1);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.White;
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRestart.Location = new System.Drawing.Point(849, 744);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(229, 28);
            this.buttonRestart.TabIndex = 14;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Extra Fan RPM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OptimizedClevoFan.Properties.Resources.Default_3;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(655, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // fanModes
            // 
            this.fanModes.BackColor = System.Drawing.SystemColors.Control;
            this.fanModes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fanModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Preset_1ToolStripMenuItem,
            this.Preset_2ToolStripMenuItem1,
            this.Preset_3ToolStripMenuItem2,
            this.Preset_4ToolStripMenuItem3,
            this.Preset_5ToolStripMenuItem,
            this.Preset_6ToolStripMenuItem});
            this.fanModes.Name = "fanModes";
            this.fanModes.Size = new System.Drawing.Size(131, 148);
            // 
            // Preset_1ToolStripMenuItem
            // 
            this.Preset_1ToolStripMenuItem.Name = "Preset_1ToolStripMenuItem";
            this.Preset_1ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.Preset_1ToolStripMenuItem.Text = "Preset 1";
            this.Preset_1ToolStripMenuItem.Click += new System.EventHandler(this.Preset_1ToolStripMenuItem_Click);
            // 
            // Preset_2ToolStripMenuItem1
            // 
            this.Preset_2ToolStripMenuItem1.Name = "Preset_2ToolStripMenuItem1";
            this.Preset_2ToolStripMenuItem1.Size = new System.Drawing.Size(130, 24);
            this.Preset_2ToolStripMenuItem1.Text = "Preset 2";
            this.Preset_2ToolStripMenuItem1.Click += new System.EventHandler(this.Preset_2ToolStripMenuItem1_Click);
            // 
            // Preset_3ToolStripMenuItem2
            // 
            this.Preset_3ToolStripMenuItem2.Name = "Preset_3ToolStripMenuItem2";
            this.Preset_3ToolStripMenuItem2.Size = new System.Drawing.Size(130, 24);
            this.Preset_3ToolStripMenuItem2.Text = "Preset 3";
            this.Preset_3ToolStripMenuItem2.Click += new System.EventHandler(this.Preset_3ToolStripMenuItem2_Click);
            // 
            // Preset_4ToolStripMenuItem3
            // 
            this.Preset_4ToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.Preset_4ToolStripMenuItem3.Name = "Preset_4ToolStripMenuItem3";
            this.Preset_4ToolStripMenuItem3.Size = new System.Drawing.Size(130, 24);
            this.Preset_4ToolStripMenuItem3.Text = "Preset 4";
            this.Preset_4ToolStripMenuItem3.Click += new System.EventHandler(this.Preset_4ToolStripMenuItem3_Click);
            // 
            // Preset_5ToolStripMenuItem
            // 
            this.Preset_5ToolStripMenuItem.Name = "Preset_5ToolStripMenuItem";
            this.Preset_5ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.Preset_5ToolStripMenuItem.Text = "Preset 5";
            this.Preset_5ToolStripMenuItem.Click += new System.EventHandler(this.Preset_5ToolStripMenuItem_Click);
            // 
            // Preset_6ToolStripMenuItem
            // 
            this.Preset_6ToolStripMenuItem.Name = "Preset_6ToolStripMenuItem";
            this.Preset_6ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.Preset_6ToolStripMenuItem.Text = "Preset 6";
            this.Preset_6ToolStripMenuItem.Click += new System.EventHandler(this.Preset_6ToolStripMenuItem_Click);
            // 
            // groupBoxGeneralInfos
            // 
            this.groupBoxGeneralInfos.BackColor = System.Drawing.Color.White;
            this.groupBoxGeneralInfos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.groupBoxGeneralInfos.Location = new System.Drawing.Point(8, 28);
            this.groupBoxGeneralInfos.Name = "groupBoxGeneralInfos";
            this.groupBoxGeneralInfos.Size = new System.Drawing.Size(367, 69);
            this.groupBoxGeneralInfos.TabIndex = 17;
            this.groupBoxGeneralInfos.UseVisualStyleBackColor = false;
            // 
            // checkBoxStartWithWindows
            // 
            this.checkBoxStartWithWindows.AutoSize = true;
            this.checkBoxStartWithWindows.BackColor = System.Drawing.Color.White;
            this.checkBoxStartWithWindows.Location = new System.Drawing.Point(19, 65);
            this.checkBoxStartWithWindows.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxStartWithWindows.Name = "checkBoxStartWithWindows";
            this.checkBoxStartWithWindows.Size = new System.Drawing.Size(139, 20);
            this.checkBoxStartWithWindows.TabIndex = 10;
            this.checkBoxStartWithWindows.Text = "Start with Windows";
            this.checkBoxStartWithWindows.UseVisualStyleBackColor = false;
            this.checkBoxStartWithWindows.CheckedChanged += new System.EventHandler(this.checkBoxStartWithWindows_CheckedChanged);
            // 
            // stepLbl
            // 
            this.stepLbl.AutoSize = true;
            this.stepLbl.BackColor = System.Drawing.Color.White;
            this.stepLbl.Location = new System.Drawing.Point(17, 39);
            this.stepLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepLbl.Name = "stepLbl";
            this.stepLbl.Size = new System.Drawing.Size(38, 16);
            this.stepLbl.TabIndex = 8;
            this.stepLbl.Text = "Step:";
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.BackColor = System.Drawing.Color.White;
            this.step.Location = new System.Drawing.Point(54, 39);
            this.step.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(46, 16);
            this.step.TabIndex = 9;
            this.step.Text = "250ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "General Info";
            // 
            // groupBoxOffset
            // 
            this.groupBoxOffset.BackColor = System.Drawing.Color.White;
            this.groupBoxOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.groupBoxOffset.Location = new System.Drawing.Point(1055, 28);
            this.groupBoxOffset.Name = "groupBoxOffset";
            this.groupBoxOffset.Size = new System.Drawing.Size(311, 69);
            this.groupBoxOffset.TabIndex = 18;
            this.groupBoxOffset.UseVisualStyleBackColor = false;
            // 
            // savePresets
            // 
            this.savePresets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.savePresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preset1ToolStripMenuItem,
            this.preset2ToolStripMenuItem,
            this.preset3ToolStripMenuItem,
            this.preset4ToolStripMenuItem,
            this.preset5ToolStripMenuItem,
            this.preset6ToolStripMenuItem});
            this.savePresets.Name = "savePresets";
            this.savePresets.Size = new System.Drawing.Size(131, 148);
            // 
            // preset1ToolStripMenuItem
            // 
            this.preset1ToolStripMenuItem.Name = "preset1ToolStripMenuItem";
            this.preset1ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset1ToolStripMenuItem.Text = "Preset 1";
            this.preset1ToolStripMenuItem.Click += new System.EventHandler(this.preset1ToolStripMenuItem_Click);
            // 
            // preset2ToolStripMenuItem
            // 
            this.preset2ToolStripMenuItem.Name = "preset2ToolStripMenuItem";
            this.preset2ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset2ToolStripMenuItem.Text = "Preset 2";
            this.preset2ToolStripMenuItem.Click += new System.EventHandler(this.preset2ToolStripMenuItem_Click);
            // 
            // preset3ToolStripMenuItem
            // 
            this.preset3ToolStripMenuItem.Name = "preset3ToolStripMenuItem";
            this.preset3ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset3ToolStripMenuItem.Text = "Preset 3";
            this.preset3ToolStripMenuItem.Click += new System.EventHandler(this.preset3ToolStripMenuItem_Click);
            // 
            // preset4ToolStripMenuItem
            // 
            this.preset4ToolStripMenuItem.Name = "preset4ToolStripMenuItem";
            this.preset4ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset4ToolStripMenuItem.Text = "Preset 4";
            this.preset4ToolStripMenuItem.Click += new System.EventHandler(this.preset4ToolStripMenuItem_Click);
            // 
            // preset5ToolStripMenuItem
            // 
            this.preset5ToolStripMenuItem.Name = "preset5ToolStripMenuItem";
            this.preset5ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset5ToolStripMenuItem.Text = "Preset 5";
            this.preset5ToolStripMenuItem.Click += new System.EventHandler(this.preset5ToolStripMenuItem_Click);
            // 
            // preset6ToolStripMenuItem
            // 
            this.preset6ToolStripMenuItem.Name = "preset6ToolStripMenuItem";
            this.preset6ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.preset6ToolStripMenuItem.Text = "Preset 6";
            this.preset6ToolStripMenuItem.Click += new System.EventHandler(this.preset6ToolStripMenuItem_Click);
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 783);
            this.Controls.Add(this.offsetValue);
            this.Controls.Add(this.offsetTrackBar);
            this.Controls.Add(this.groupBoxOffset);
            this.Controls.Add(this.step);
            this.Controls.Add(this.stepLbl);
            this.Controls.Add(this.checkBoxStartWithWindows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxGeneralInfos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelFanInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fanModes.ResumeLayout(false);
            this.savePresets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.TrackBar offsetTrackBar;
        private System.Windows.Forms.Label offsetValue;
        private System.Windows.Forms.FlowLayoutPanel panelFanInfos;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip fanModes;
        private System.Windows.Forms.ToolStripMenuItem Preset_1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Preset_2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Preset_3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Preset_4ToolStripMenuItem3;
        private System.Windows.Forms.CheckBox checkBoxStartWithWindows;
        private System.Windows.Forms.Label stepLbl;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button groupBoxGeneralInfos;
        private System.Windows.Forms.Button groupBoxOffset;
        private System.Windows.Forms.ToolStripMenuItem Preset_5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Preset_6ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip savePresets;
        private System.Windows.Forms.ToolStripMenuItem preset1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset6ToolStripMenuItem;
    }
}

