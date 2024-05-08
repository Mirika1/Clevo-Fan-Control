namespace OptimizedClevoFan
{
    partial class FanTemp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempTrackBar = new System.Windows.Forms.TrackBar();
            this.tempLbl = new System.Windows.Forms.Label();
            this.rpmLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tempTrackBar
            // 
            this.tempTrackBar.AutoSize = false;
            this.tempTrackBar.Location = new System.Drawing.Point(1, 15);
            this.tempTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.tempTrackBar.Maximum = 100;
            this.tempTrackBar.Name = "tempTrackBar";
            this.tempTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tempTrackBar.Size = new System.Drawing.Size(27, 204);
            this.tempTrackBar.TabIndex = 0;
            this.tempTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tempTrackBar.Scroll += new System.EventHandler(this.tempTrackBar_Scroll);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(-1, 219);
            this.tempLbl.Margin = new System.Windows.Forms.Padding(0);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(29, 12);
            this.tempLbl.TabIndex = 1;
            this.tempLbl.Text = "100 C";
            // 
            // rpmLbl
            // 
            this.rpmLbl.AutoSize = true;
            this.rpmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmLbl.Location = new System.Drawing.Point(-1, 6);
            this.rpmLbl.Margin = new System.Windows.Forms.Padding(0);
            this.rpmLbl.Name = "rpmLbl";
            this.rpmLbl.Size = new System.Drawing.Size(30, 12);
            this.rpmLbl.TabIndex = 2;
            this.rpmLbl.Text = "100 %";
            // 
            // FanTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpmLbl);
            this.Controls.Add(this.tempLbl);
            this.Controls.Add(this.tempTrackBar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FanTemp";
            this.Size = new System.Drawing.Size(31, 235);
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tempTrackBar;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label rpmLbl;
    }
}
