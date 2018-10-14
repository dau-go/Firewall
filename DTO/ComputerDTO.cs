using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComputerDTO
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _IP;
        public string IP
        {
            get { return _IP; }
            set { _IP = value; }
        }
    }
}
