using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlottingData
{
    internal class DataEntry
    {
        public string Raw { get; set; }
        public DateTime Time { get; set; }
        public double Pressure { get; set; }
        public double Altitude { get; set; }
        public double BitRate { get; set; }
        public double Pitch { get; set; }
        public double SlantRange { get; set; }
        public double DistanceToTarget { get; set; }
        public double Roll { get; set; }

        /// <summary>
        /// Constructor that will parse a line from a selected file.
        /// </summary>
        /// <param name="line"></param>
        public DataEntry(string line)
        {
            this.Raw = line;
            List<string> splitLine = line.Split(',').ToList();
            DateTime time;
            bool res = DateTime.TryParse(splitLine[0], out time);
            if (res)
            {
                this.Time = time;
            }            
            double pressure;
            res = Double.TryParse(splitLine[1], out pressure);
            if (res)
            {
                this.Pressure = pressure;
            }
            double altitude;
            res = Double.TryParse(splitLine[2], out altitude);
            if (res)
            {
                this.Altitude = altitude;
            }
            double bitRate;            
            res = Double.TryParse(splitLine[3], out bitRate);
            if (res)
            {
                this.BitRate = bitRate;
            }
            double pitch;
            res = Double.TryParse(splitLine[4], out pitch);
            if (res)
            {
                this.Pitch = pitch;
            }
            double slantRange;
            res = Double.TryParse(splitLine[5], out slantRange);
            if (res)
            {
                this.SlantRange = slantRange;
            }
            double distanceToTarget;
            res = Double.TryParse(splitLine[6], out distanceToTarget);
            if (res)
            {
                this.DistanceToTarget = distanceToTarget;
            }
            double roll;
            res = Double.TryParse(splitLine[7], out roll);
            if (res)
            {
                this.Roll = roll;
            }
        }

        /// <summary>
        /// Returns the raw line of data created from the contructed DataEntry.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Time.ToString("T")},{this.Pressure},{this.Altitude},{this.BitRate},{this.Pitch}," +
                $"{this.SlantRange},{this.DistanceToTarget},{this.Roll}";
        }
    }
}
