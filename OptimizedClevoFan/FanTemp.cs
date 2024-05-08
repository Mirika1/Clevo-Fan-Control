using System;
using System.Windows.Forms;

namespace OptimizedClevoFan
{
    public partial class FanTemp : UserControl
    {
        private Fan fan;
        private int temperatureRange;

        public FanTemp(Fan fan, int temperatureRange)
        {
            InitializeComponent();
            this.fan = fan;
            this.temperatureRange = temperatureRange;

            this.tempLbl.Text = (this.temperatureRange * this.fan.degreesStepSize).ToString() + " C";

            int rpm = this.fan.GetConfiguredRPMAtStep(this.temperatureRange);
            this.tempTrackBar.Value = rpm;
            this.rpmLbl.Text = rpm.ToString() + " %";
        }

        private void tempTrackBar_Scroll(object sender, EventArgs e)
        {
            this.fan.SetConfiguredRPMAtStep(this.temperatureRange, this.tempTrackBar.Value);
            this.rpmLbl.Text = this.tempTrackBar.Value.ToString() + " %";
        }
    }
}
