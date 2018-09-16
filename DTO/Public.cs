using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DTO
{
    public class Public
    {
        private static int _Next1;
        public static int Next1
        {
            get { return _Next1; }
            set { _Next1 = value; }
        }
        private static string _Name;
        public static string NameRule
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private static string _Description;
        public static string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private static string _Action;
        public static string Action
        {
            get { return _Action; }
            set { _Action = value; }
        }
        private static string _Program;
        public static string Program
        {
            get { return _Program; }
            set { _Program = value; }
        }
        private static string _LocalPort;
        public static string LocalPort
        {
            get { return _LocalPort; }
            set { _LocalPort = value; }
        }
        private static string _RemotePort;
        public static string RemotePort
        {
            get { return _RemotePort; }
            set { _RemotePort = value; }
        }
        private static string _LocalIP;
        public static string LocalIP
        {
            get { return _LocalIP; }
            set { _LocalIP = value; }
        }
        private static string _RemoteIP;
        public static string RemoteIP
        {
            get { return _RemoteIP; }
            set { _RemoteIP = value; }
        }
        private static string _Profile;
        public static string Profile
        {
            get { return _Profile; }
            set { _Profile = value; }
        }
    }
}
