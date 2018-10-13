using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class IPDestinationDTO
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private bool _Statebool;

        public bool Statebool
        {
            get { return _Statebool; }
            set { _Statebool = value; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _State;

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        private string _Action;

        public string Action
        {
            get { return _Action; }
            set { _Action = value; }
        }
        private string _IPDestination;

        public string IPDestination
        {
            get { return _IPDestination; }
            set { _IPDestination = value; }
        }
    }
}
