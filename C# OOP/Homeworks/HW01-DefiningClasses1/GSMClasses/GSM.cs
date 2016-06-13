namespace GSMClasses
{
    using Components;
    using Features;
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private static GSM iPhone4S = new GSM("Iphone 4S", "Apple", 629.00m, new Battery(BatteryType.LiPo, 200, 14), new Display(3.5, 16000000));

        // Didnt add checks because string fields can be anything and every other field
        // takes either the correct arguments or will prompt build errors.
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public static string IPhone4S
        {
            get
            {
                return iPhone4S.ToString();
            }
        }
        public List<Call> CallHistory { get; set; } = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, Battery battery) : this(model, manufacturer, price)
        {
            this.Battery = battery;
        }
        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
            : this(model, manufacturer, price, battery)
        {
            this.Display = display;
        }
        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display, string owner)
            : this(model, manufacturer, price, battery, display)
        {
            this.Owner = owner;
        }


        public override string ToString()
        {
            string output = "";
            output += "GSM Info\n";
            output += "Model: " + this.Model + "\n";
            output += "Manufacturer: " + this.Manufacturer + "\n";
            if (Price != null)
            {
                output += "Price: " + String.Format("{0:F2}", this.Price) + " Euro\n";
            }
            else
            {
                output += "Price: Not for sale.\n";
            }

            if (Battery != null)
            {
                output += "Battery info\n";
                output += "Model: " + this.Battery.Model + "\n";
                output += "Hours standby: " + this.Battery.HoursIdle + " hours\n";
                output += "Talk time: " + this.Battery.HoursTalk + " hours\n";
            }
            else
            {
                output += "Battery: Battery not set.\n";
            }


            if (Display != null)
            {
                output += "Display Info\n";
                output += "Size: " + this.Display.Size + " inches\n";
                output += "Colors variety: " + this.Display.ColorCapacity + "\n";
            }
            else
            {
                output += "Display Info: Display not set.\n";
            }

            if (Owner != null)
            {
                output += "Owner Name: " + Owner;
            }
            else
            {
                output += "Owner: This phone does not have an owner yet.";
            }


            return output;
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void DeleteCall(int index)
        {
            CallHistory.RemoveAt(index);
        }
        public void DeleteLastcall()
        {
            CallHistory.RemoveRange(CallHistory.Count - 1, 1);
        }
        public void ClearCalls()
        {
            CallHistory.Clear();
        }
        public decimal CallsPrice(decimal pricePerMinute)
        {
            decimal result = pricePerMinute;
            foreach (var item in CallHistory)
            {
                result += item.Duration / 60 * pricePerMinute;
            }

            return result;
        }
    }
}
