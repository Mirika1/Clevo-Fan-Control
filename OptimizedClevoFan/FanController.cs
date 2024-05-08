using System;
using System.Collections.Generic;

namespace OptimizedClevoFan
{
    class FanController
    {
        private IFanControl fanControl;

        public int updateFanStep { get; set; }

        public int numberOfValuesForAvgTemperature { get; set; }

        public List<Fan> fans { get; set; }

        public FanController()
        {
            // Create interface to communicate with fans & CPU temps
            fanControl = new FanControl();

            // List containing all fans
            this.fans = new List<Fan>();
        }
        public void LoadDefaults()
        {
            // Default values
            this.updateFanStep = 550;
            this.numberOfValuesForAvgTemperature = 4;
            
            
                                     // 0   1   2   3   4   5   6   7   8   9  10  11  12  13  14   15  16
                                     // 0   5  10  15  20  25  30  35  40  45  50  55  60  65  70   75  80
            int[] temps1 = new int[] { 19, 19, 19, 19, 19, 19, 19, 19, 19, 34, 34, 34, 34, 34, 34, 34, 34, 45, 55, 65, 100 };
            //int[] temps1 = new int[] { 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 34, 34, 34, 34, 45, 55, 65, 100 };
            Fan fanControl1 = new Fan(fanControl, 1, "CPU", this.numberOfValuesForAvgTemperature);
            fanControl1.LoadTemps(temps1);
            this.fans.Add(fanControl1);

                                     // 0   1   2   3   4   5   6   7   8   9  10  11  12  13   14   15   16
                                     // 0   5  10  15  20  25  30  35  40  45  50  55  60  65   70   75   80
            int[] temps2 = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 35, 35, 35, 35, 85, 100, 100, 100, 100, 100, 100, 100, 100 };
            Fan fanControl2 = new Fan(fanControl, 2, "GPU", this.numberOfValuesForAvgTemperature);
            fanControl2.LoadTemps(temps2);
            this.fans.Add(fanControl2);
        }

        public IFanControl GetFanControl() 
        {
            return this.fanControl;
        }

        public void DoUpdate(int offset)
        {
            int maxOfAllFans = 0;
            foreach (Fan fan in this.fans)
            {
                fan.UpdateAvgTemperature();
                fan.CalculateDesiredRPM(offset);
                maxOfAllFans = Math.Max(maxOfAllFans, fan.GetDesiredRPM());
            }

            // set all fans to 80% of the one that is running faster (at more RPMs)
            int minimumFanRPM = (int)((double)maxOfAllFans * 0);
            // if one of the fans is at more than 100% then I set all the fans at 100%
            //if (maxOfAllFans >= 100)
                //minimumFanRPM = 100;

            foreach (Fan fan in this.fans)
                fan.SetFanRPM(minimumFanRPM);
        }

        public void Finish()
        {
            // Set default fan RPMs
            foreach (Fan fan in this.fans)
                fanControl.SetFansAuto(fan.GetFanNumber());

            // Delete interface for communicating with fans & CPU temps
            fanControl.Dispose();
        }
    }
}
