using ies_admin_academ.Controller;
using ies_admin_academ.Model;

namespace ies_admin_academ
{
    public partial class login : Form
    {
        //Instantiate Setting objects
        IES iesCfg = new IES();
        //Control to enable/disable login execution button
        bool username = false, pwd = false;

        void enableLoginButton() {
            if (username && pwd) { 
                this.login_execution_btn.Enabled = true;
            }
            else
            {
                this.login_execution_btn.Enabled = false;
            }

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            int chars = this.login_username.Text.Length;
            if (chars >= 4) { 
                username = true;
            }
            else
            {
                username = false;
            }
            enableLoginButton();
        }

        private void login_pwd_TextChanged(object sender, EventArgs e)
        {
            int chars = this.login_pwd.Text.Length;
            if (chars >= 4)
            {
                pwd = true;
            }
            else
            {
                pwd = false;
            }
            enableLoginButton();
        }

        

        public login()
        {
            InitializeComponent();
            enableLoginButton();
            this.Text = iesCfg.ies_name + " - " + iesCfg.ies_app_env; //Title of window
            main_login_titleIES.Text = iesCfg.ies_name; //Text label 1
            main_login_appenvText.Text = iesCfg.ies_app_env; //Text label 2

        }

        private void login_execution_btn_Click(object sender, EventArgs e)
        {
            //Encode data
            string toSend = IES_TextEncoder.joinString(login_username.Text, login_pwd.Text);
            
            loginExecution.executeLogin(toSend,this);
        }
    }
}