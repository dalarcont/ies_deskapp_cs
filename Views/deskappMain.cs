using ies_admin_academ.Controller.DAO;
using ies_admin_academ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ies_admin_academ.Views
{
    public partial class deskappMain : Form
    {
        //Read settings
        IES cfg = new IES();
        userProfile[] userProfile;
        public deskappMain(string usrCrdntls)
        {
            InitializeComponent();
            deskapp_title_label.Text = cfg.ies_name;
            deskapp_title_env_label.Text = cfg.ies_app_env;
            this.Text = cfg.ies_name + " - " + cfg.ies_app_env;
            //Retrieve user data
            userProfile = API_Users.getUserProfileData(usrCrdntls);
            AppPermissions[] appPermissions = API_Users.getUserAppPermissions(usrCrdntls);
            if(userProfile != null) {

                deskapp_bottom_statusbar_label.Text =
                    "Hola! " +
                    userProfile[0].Nombres +
                    " " +
                    userProfile[0].Apellidos +
                    ". /// Unidad: " +
                    userProfile[0].NombreUnidad +
                    ". /// Cargo: " +
                    userProfile[0].NombreCargo +
                    ". /// Último ingreso: " +
                    userProfile[0].UltimoAcceso;
                //Save current date as the user's last access date (current date are set by API Server, not by this software).
                API_Users.setLastAccessRecord(usrCrdntls);
            } else
            {
                //Due to this service fails its mandatory to close inmediately the app. The data retrieved here is strictly needed.
                Application.Exit();
            }

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
