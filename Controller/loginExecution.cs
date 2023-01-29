using ies_admin_academ.Controller.DAO;
using ies_admin_academ.Model;
using ies_admin_academ.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Controller
{
    public static class loginExecution
    {
        /// <summary>
        /// Controller procedure to execut login process.
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static void executeLogin(string data, login loginView) { 
            //1st api consumption container object
            appLogin result = API_Users.validateAccess(data);

            //Verify if result is null due to unavailable API server
            if(result == null)
            {
                //Server isn't available or resource isn't called properly
                //Close application
                Application.Exit();
            }
            else
            {
                //It means the result have an operable object loaded
                if (result.R) {
                    //1st API consumption successful
                    //Perform 2nd consumption to validate if user have access to deskapp
                    appLogin result2 = API_Users.validateAccessDeskapp(data);

                    //Verify is result is null due to unavailable API server
                    if (result2 == null)
                    {
                        //Server isn't available or resource isn't called properly
                        //At this point isn't mandatory to close the app
                        Application.Exit();
                    }
                    else
                    {
                        //It means the result of 2nd consumption have an operable object loaded
                        if (result2.R)
                        {
                            //User have access to deskapp enabled
                            loginView.Hide();
                            var deskappMainWindow = new deskappMain(data);
                            deskappMainWindow.ShowDialog();
                            loginView.Close();
                        }
                        else
                        {
                            //2nd API consumption was not successful
                            MessageBox.Show(
                            "Error API-" +
                            result.Code +
                            Environment.NewLine +
                            result.Message
                            ,
                            "Acceso al sistema"
                            ,
                            MessageBoxButtons.OK
                            ,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                }
                else
                {
                    //1st API consumption was not successful
                    MessageBox.Show(
                    "Error API-" +
                    result.Code +
                    Environment.NewLine +
                    result.Message
                    ,
                    "Acceso al sistema"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
