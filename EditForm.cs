using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class EditForm : Form
    {
        private static string _Name;
        public static string NameRule
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private static string _State;
        public static string State
        {
            get { return _State; }
            set { _State = value; }
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
        private static string _Protocol;
        public static string Protocol
        {
            get { return _Protocol; }
            set { _Protocol = value; }
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
        public EditForm()
        {
            InitializeComponent();
            txtName.Text = NameRule;
            txtDescription.Text = Description;
            if (State == "Yes")
            {
                ckState.Checked = true;
            }
            else
            {
                ckState.Checked = false;
            }
            if (Action == "Allow")
            {
                rbAllow.Checked = true;
            }
            else
            {
                rbBlock.Checked = true;
            }
            if (Program == "Any")
            {
                rbAllProgram.Checked = true;
                txtProgram.Enabled = false;
                btnBrowes.Enabled = false;
            }
            else
            {
                rbThisProgram.Checked = true;
                txtProgram.Text = Program;
                btnBrowes.Enabled = true;
            }
            switch (Profile)
            {
                case "Domain":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Domain, Private":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Domain, Private, Public":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Domain, Public":
                    {
                        cbDomain.Checked = true;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Private":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = false;
                        break;
                    }
                case "Private, Public":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = true;
                        cbPublic.Checked = true;
                        break;
                    }
                case "Public":
                    {
                        cbDomain.Checked = false;
                        cbPrivate.Checked = false;
                        cbPublic.Checked = true;
                        break;
                    }
            }
            cbProtocol.Text = Protocol;
            if (LocalPort == "Any")
            {
                cbLocalport.SelectedIndex = 0;
                txtLocalport.Enabled = false;
            }
            else
            {
                cbLocalport.SelectedIndex = 1;
                txtLocalport.Enabled = true;
                txtLocalport.Text = LocalPort;
            }
            if (RemotePort == "Any")
            {
                cbRemoteport.SelectedIndex = 0;
                txtRemoteport.Enabled = false;
            }
            else
            {
                cbRemoteport.SelectedIndex = 1;
                txtRemoteport.Enabled = true;
                txtRemoteport.Text = RemotePort;
            }
            if (LocalIP == "Any")
            {
                rbAllLocal.Checked = true;
                btnAddLocal.Enabled = false;
                btnEditLocal.Enabled = false;
                btnDelLocal.Enabled = false;
            }
            else
            {
                rbIPLocal.Checked = true;
                btnAddLocal.Enabled = true;
                btnEditLocal.Enabled = false;
                btnDelLocal.Enabled = false;
                string[] s = LocalIP.Split(',');
                for (int i = 0; i < s.Length; i++)
                {
                    listView1.Items.Add(s[i]);
                }
            }
            if (RemoteIP == "Any")
            {
                rbAllRemote.Checked = true;
                btnAddRemote.Enabled = true;
                btnEditRemote.Enabled = false;
                btnDelRemote.Enabled = false;
            }
            else
            {
                rbIPLocal.Checked = true;
                btnAddRemote.Enabled = true;
                btnEditRemote.Enabled = false;
                btnDelRemote.Enabled = false;
                string[] s = RemoteIP.Split(',');
                for (int i = 0; i < s.Length; i++)
                {
                    listView2.Items.Add(s[i]);
                }
            }
        }
    }
}
