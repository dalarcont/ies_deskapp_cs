using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Model
{
    public class AppPermissions
    {
        private String username;
        private String app_name;
        private bool permission;

        public AppPermissions()
        {
        }

        public AppPermissions(string username, string app_name, bool permission)
        {
            this.Username = username;
            this.App_name = app_name;
            this.Permission = permission;
        }

        public string Username { get => username; set => username = value; }
        public string App_name { get => app_name; set => app_name = value; }
        public bool Permission { get => permission; set => permission = value; }
    }
}
