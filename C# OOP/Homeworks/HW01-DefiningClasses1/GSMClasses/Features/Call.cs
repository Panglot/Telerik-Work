namespace GSMClasses.Features
{
    public class Call
    {
        public string Day { get; set; }
        public string Time { get; set; }
        public string Number { get; set; }
        public uint Duration { get; set; }


        public Call()
        {

        }
        public Call(string day, string time, string number, uint duration)
        {
            this.Day = day;
            this.Time = time;
            this.Number = number;
            this.Duration = duration;
        }


        public override string ToString()
        {     

            string output = "";
            output += "Date: " + this.Day + " " + this.Time;
            output += "\nNumber: " + this.Number + "\n";
            output += "Duration: " + this.Duration + " seconds\n";
            return output;
        }
    }
}
