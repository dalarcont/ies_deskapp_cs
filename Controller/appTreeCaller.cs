using ies_admin_academ.Views.Apps.DK_AKA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Controller
{
    public class appTreeCaller
    {

        public void clickedNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Get app code
            string appCode = e.Node.Name;
            //Get app name
            string appName = e.Node.Text;

            //Validate if the required app is already open
            if (!appName.Contains(" ***** APLICACIÓN ACTIVA *****"))
            {
                //The app can be invoked
                e.Node.Text += " ***** APLICACIÓN ACTIVA *****";    //Set a text to indicate in UI that the current app is open
                //Instantiate form
                TestingWindow app = new TestingWindow();
                /*
                 TESTING
                 */
                app.Text = appName;    //Set title of the window
                app.FormClosed += new FormClosedEventHandler(onCloseAppWindow);
                app.Show();
                //</test>
            }
            else {
                //Application is already open so it won't run
                MessageBox.Show("Está aplicación ya se encuentra en uso.", "Apertura de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            void onCloseAppWindow(object sender, FormClosedEventArgs fcea)
            {
                //When user closes the required app, restore app item on treeview
                e.Node.Text = appName;
            }
        }

        


    }
}
