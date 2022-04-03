using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlottingData
{
    internal class DataSet
    {
        public string FilePath { get; set; }
        public List<string> ColumnNames { get; set; }
        public List<DataEntry> Data { get; set; }
        public string RawHeader { get; set; }
        public bool Empty { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DataSet()
        {
            this.FilePath = null;
            this.ColumnNames = new List<string>();
            this.Data = new List<DataEntry>();
        }

        /// <summary>
        /// Constuctor that parses a data file.
        /// </summary>
        /// <param name="filePath"></param>
        public DataSet(string filePath)
        {
            if (File.Exists(filePath))
            {
                this.FilePath = filePath;
                this.ColumnNames = new List<string>();
                this.Data = new List<DataEntry>();
                ReadDataFile(filePath);
            }
        }

        /// <summary>
        /// Constructor that takes all properties 
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="filePath"></param>
        /// <param name="data"></param>
        public DataSet(string rawHeader, string filePath, List<DataEntry> data)
        {
            this.RawHeader = rawHeader;
            this.FilePath = filePath;
            this.Data = data;
        }

        /// <summary>
        /// Parses data from given data file and populates the attributes of the class properties.
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadDataFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                this.FilePath = filePath;
                int lineNum = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNum == 0)
                        {
                            this.ColumnNames.Add(line);
                            this.RawHeader = line;
                        }
                        else if (lineNum > 0)
                        {
                            this.Data.Add(new DataEntry(line));
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}
