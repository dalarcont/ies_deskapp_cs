using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Model
{
    public class user_dkApps
    {
        private string user;
        private string appcode;
        private bool permission;
        private string appname;
        private string appdescr;
        private int treelevel;

        public user_dkApps()
        {
        }

        public user_dkApps(string user, string appcode, bool permission, string appname, string appdescr, int treelevel)
        {
            this.User = user;
            this.Appcode = appcode;
            this.Permission = permission;
            this.Appname = appname;
            this.Appdescr = appdescr;
            this.Treelevel = treelevel;
        }

        public string User { get => user; set => user = value; }
        public string Appcode { get => appcode; set => appcode = value; }
        public bool Permission { get => permission; set => permission = value; }
        public string Appname { get => appname; set => appname = value; }
        public string Appdescr { get => appdescr; set => appdescr = value; }
        public int Treelevel { get => treelevel; set => treelevel = value; }
    }
}
