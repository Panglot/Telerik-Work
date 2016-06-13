namespace GSMClasses.Components
{
    using System;

    public class Battery
    {
        public BatteryType Model { get; set; }
        public Double HoursIdle { get; set; }
        public Double HoursTalk { get; set; }

        public Battery()
        {

        }
        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
