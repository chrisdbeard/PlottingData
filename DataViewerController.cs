using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlottingData
{
    internal class DataViewerController
    {
        public DataSet Data { get; set; }
        public string FilePath { get; set; }

        /// <summary>
        /// Reads the data file from given file path and populates the events in this.Data
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadDataSet(string filePath)
        {
            this.FilePath = filePath;
            this.Data = new DataSet(filePath);
        }
    }
}
