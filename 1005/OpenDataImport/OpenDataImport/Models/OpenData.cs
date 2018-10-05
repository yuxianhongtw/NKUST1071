using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDataImport.Models
{
    public class OpenData
    {
        /*private int _id;
        public int Id {
            get {
                return _id;
            }
            set {
                this._id = value;
            }
        }*/

        public string Area { get; set; }
        public string BasinName { get; set; }
        public string Location { get; set; }
        public string ReservoirName { get; set; }


        /* public string Get資料集名稱() {
             return "";
         }*/
    }
}