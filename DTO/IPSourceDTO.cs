using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class IPSourceDTO
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _Month;

        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }
        private string _IPSource;

        public string IPSource
        {
            get { return _IPSource; }
            set { _IPSource = value; }
        }
        private string _IPDestination;

        public string IPDestination
        {
            get { return _IPDestination; }
            set { _IPDestination = value; }
        }
        private string _Time;

        public string Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
    }
}
