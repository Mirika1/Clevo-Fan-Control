using System;
using System.Collections.Generic;

namespace OptimizedClevoFan
{
    public class Fan
    {
        private IFanControl fanControl;

        private int instant_temperature;
        private int desired_fan_rpm;
        private double last_fan_rpm;

        private Queue<int> last_temperatures;
        private int numberOfValuesForAvgTemperature;

        private int max_temperature;
        private double avg_temperature;
        private int number_of_avg_records;

        // PARAMS
        public int fanNumber;
        public string name;
        public double rpmStepUp = 2.5;
        public double rpmStepDown = 0.1;
        public int degreesStepSize = 5;
        public int[] configuredRPMs;

        public Fan(IFanControl fanControl, int fanNumber, string name, int numberOfValuesForAvgTemperature)
        {
            this.fanControl = fanControl;
            this.fanNumber = fanNumber;
            this.name = name;
            this.numberOfValuesForAvgTemperature = numberOfValuesForAvgTemperature;

            this.instant_temperature = 0;
            this.max_temperature = this.instant_temperature;
            this.avg_temperature = this.instant_temperature;
            this.number_of_avg_records = 1;
            this.last_temperatures = new Queue<int>();
            this.desired_fan_rpm = 25;
            this.last_fan_rpm = (double)this.desired_fan_rpm;
        }

        public void SetFanControl(IFanControl fanControl)
        {
            this.fanControl = fanControl;
        }

        public void SetNumberOfValuesForAvgTemperature(int numberOfValuesForAvgTemperature)
        {
            this.numberOfValuesForAvgTemperature = numberOfValuesForAvgTemperature;
        }

        public int GetFanNumber() { return fanNumber; }

        public int GetDesiredRPM() { return this.desired_fan_rpm; }

        public double GetLastRPM() { return this.last_fan_rpm; }

        public int GetTemperature() { return this.instant_temperature; }

        public int GetConfiguredRPMAtStep(int stepPosition) { return this.configuredRPMs[stepPosition]; }

        public void SetConfiguredRPMAtStep(int stepPosition, int rpmValue) 
        {
            if(rpmValue < 0)
                rpmValue = 0;

            if (rpmValue > 100)
                rpmValue = 100;

            this.configuredRPMs[stepPosition] = rpmValue;
        }

        public int GetAvgTemperature() { return (int)this.avg_temperature; }

        public int GetMaxTemperature() { return (int)this.max_temperature; }

        public void LoadTemps(int[] temps)
        {
            this.configuredRPMs = temps;
        }

        public void UpdateAvgTemperature()
        {
            int instant_temperature = (int)fanControl?.GetECData(this.fanNumber).Remote;

            // ----------------------------------------------------------------------------------------------------
            // Get average temperature for the last steps

            last_temperatures.Enqueue(instant_temperature);
            if (last_temperatures.Count > this.numberOfValuesForAvgTemperature)
                last_temperatures.Dequeue();

            int cpu_temp_avg = 0;
            foreach (int temp in last_temperatures)
                cpu_temp_avg += temp;
            cpu_temp_avg /= this.numberOfValuesForAvgTemperature;

            this.instant_temperature = cpu_temp_avg;

            //this.avg_temperature = instant_temperature;
            // ----------------------------------------------------------------------------------------------------

            // Calculate avg temperature since running
            // https://math.stackexchange.com/questions/106313/regular-average-calculated-accumulatively
            this.number_of_avg_records++;
            double up = ((this.avg_temperature * (this.number_of_avg_records - 1)) + this.instant_temperature);
            double down = (double)this.number_of_avg_records;
            this.avg_temperature = (up/down);

            // Check if max temperature has been overpassed
            if( this.instant_temperature > this.max_temperature)
                this.max_temperature = this.instant_temperature;
        }

        public void CalculateDesiredRPM(int offset)
        {
            if (configuredRPMs.Length == 0)
                return;

            // ----------------------------------------------------------------------------------------------------
            // Ramp calculation

            int vec_value_low = this.instant_temperature / this.degreesStepSize;
            if (vec_value_low >= configuredRPMs.Length)
                vec_value_low = configuredRPMs.Length - 1;
            if (vec_value_low < 0)
                vec_value_low = 0;

            int vec_value_high = (this.instant_temperature / this.degreesStepSize) + 1;
            if (vec_value_high >= configuredRPMs.Length)
                vec_value_high = configuredRPMs.Length - 1;
            if (vec_value_high < 0)
                vec_value_high = 0;

            int temp_low = configuredRPMs[vec_value_low];
            int temp_high = configuredRPMs[vec_value_high];

            int extra_degrees = this.instant_temperature % this.degreesStepSize;
            double diff = (double)extra_degrees / (double)this.degreesStepSize;
            diff *= (double)(temp_high - temp_low);

            this.desired_fan_rpm = configuredRPMs[vec_value_low] + (int)diff;

            // Add offset
            this.desired_fan_rpm += offset;

            // ----------------------------------------------------------------------------------------------------
        }

        public void SetFanRPM(int minimum_fan_rpm)
        {
            // Only change fan speed if it has changed (save original value)
            double original_last_fan_rpm = Math.Truncate(this.last_fan_rpm * 10.0);

            int definitive_fan_rpm = this.desired_fan_rpm;
            if (this.desired_fan_rpm < minimum_fan_rpm)
                definitive_fan_rpm = minimum_fan_rpm;

            if (definitive_fan_rpm >= this.last_fan_rpm)
            {
                this.last_fan_rpm += this.rpmStepUp;
            }
            else
            {
                if ((this.last_fan_rpm - this.rpmStepDown) > definitive_fan_rpm)
                    this.last_fan_rpm -= this.rpmStepDown;
            }

            if (this.last_fan_rpm > 100)
                this.last_fan_rpm = 100;

            if (this.last_fan_rpm < 0)
                this.last_fan_rpm = 0;

            // Only change fan speed if it has changed
            if(original_last_fan_rpm != Math.Truncate(this.last_fan_rpm * 10.0))
                fanControl?.SetFanSpeed(this.fanNumber, this.last_fan_rpm);
        }

    }
}
