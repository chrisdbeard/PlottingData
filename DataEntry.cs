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
            this.Time = DateTime.Parse(splitLine[0]);
            this.Pressure = double.Parse(splitLine[1]);
            this.Altitude = double.Parse(splitLine[2]);
            this.BitRate = double.Parse(splitLine[3]);
            this.Pitch = double.Parse(splitLine[4]);
            this.SlantRange = double.Parse(splitLine[5]);
            this.DistanceToTarget = double.Parse(splitLine[6]);
            this.Roll = double.Parse(splitLine[7]);
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
