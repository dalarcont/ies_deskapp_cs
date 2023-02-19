using ies_admin_academ.Controller;
using ies_admin_academ.Controller.DAO;
using ies_admin_academ.Model;
using NHibernate.Linq;
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
        user_dkApps[] dkapps;
        appTreeCaller appTree = new appTreeCaller();

        /// <summary>
        /// Build TreeView with the apps wich user have permission
        /// </summary>
        /// <param name="appsObjArr">List of app with permissions</param>
        private void buildAppTree(user_dkApps[] appsObjArr) { 
            //Convert to list
            List<user_dkApps> apps = appsObjArr.ToList();

            //Size of tab according to number of levels
            int tabIndex = 4; //Modify when you decrease or increase levels

            //Object list of apps by its level
            List<user_dkApps> level0 = new List<user_dkApps>();
            List<user_dkApps> level1 = new List<user_dkApps>();
            List<user_dkApps> level2 = new List<user_dkApps>();
            List<user_dkApps> level3 = new List<user_dkApps>();
			
			//Empty auxiliar list of nodes
            List<System.Windows.Forms.TreeNode> tempNodeL0 = new List<System.Windows.Forms.TreeNode>();
            List<System.Windows.Forms.TreeNode> tempNodeL1 = new List<System.Windows.Forms.TreeNode>();
            List<System.Windows.Forms.TreeNode> tempNodeL2 = new List<System.Windows.Forms.TreeNode>();
            List<System.Windows.Forms.TreeNode> tempNodeL3 = new List<System.Windows.Forms.TreeNode>();

            //Filter and save app in its level object list
            foreach (user_dkApps app in apps) {
                if (app.Treelevel == 0) { level0.Add(app); }
                if (app.Treelevel == 1) { level1.Add(app); }
                if (app.Treelevel == 2) { level2.Add(app); }
                if (app.Treelevel == 3) { level3.Add(app); }
            }

            
            //LEVEL 0 ITERATION
            foreach (user_dkApps app in level0) {
                //Get from level1 apps related to the first app/criteria of level0
                List<user_dkApps> tempLevel1 = new List<user_dkApps>();
                var objs = level1.Where(x => x.Appcode.StartsWith(app.Appcode));

                //LEVEL 1 ITERATION
                foreach (var obj in objs) {
                    //Get from level2 apps related to the first app/criteria of level1
                    List<user_dkApps> tempLevel2 = new List<user_dkApps>();
                    var objs2 = level2.Where(x => x.Appcode.StartsWith(obj.Appcode));

                    //LEVEL 2 ITERATION
                    foreach (var obj2 in objs2) {
                        //Get from level3  apps related to the first app/criteria of level2
                        List<user_dkApps> tempLevel3 = new List<user_dkApps>();
                        var objs3 = level3.Where(x => x.Appcode.StartsWith(obj2.Appcode));

                        //LEVEL 3 ITERATION
                        foreach (var obj3 in objs3) {
                            //Create node level 3 --- It means the final children objects.
                            //From here it will be treated like a recursive filling the parent nodes.
                            System.Windows.Forms.TreeNode treeNode_temp3 = new System.Windows.Forms.TreeNode();
                            treeNode_temp3.Text = obj3.Appname; //Node name for view
                            treeNode_temp3.Name = obj3.Appcode;  //Node code for app caller
                            treeNode_temp3.ToolTipText = obj3.Appdescr;  //Node tooltip text
                            tempNodeL3.Add(treeNode_temp3);  //Add node to list
                            System.Diagnostics.Debug.WriteLine(treeNode_temp3.Name);
                        }
						//END LEVEL 3 ITERATION
                        
                        //Apply parent node properties and data
                            //Create parent node and set the name and set dataset of its children nodes
                            System.Windows.Forms.TreeNode treeNode_temp2 = new System.Windows.Forms.TreeNode();
                            treeNode_temp2.Text = obj2.Appname;	//Node name for view
                            treeNode_temp2.Nodes.AddRange(tempNodeL3.ToArray()); //Save level 3 apps on its respectively parent node
                            treeNode_temp2.Name = obj2.Appcode;  //Node code for app caller
                            treeNode_temp2.ToolTipText = obj2.Appdescr;  //Node tooltip text
                            //Set parent node as child of the next parent node and clear children node processor to avoid repeated nodes.
                            TreeNode parent2 = new TreeNode();
                            parent2.Text = obj2.Appname;
                            parent2.Name = obj2.Appcode;
                            parent2.ToolTipText = obj2.Appdescr;
                            parent2.Nodes.AddRange(tempNodeL3.ToArray());
                            tempNodeL2.Add(parent2); tempNodeL3.Clear();
                    }//END LEVEL 2 ITERATION

                    //Apply parent node properties and data
                        //Create parent node and set the name and set dataset of its children nodes
                        System.Windows.Forms.TreeNode treeNode_temp1 = new System.Windows.Forms.TreeNode();
                        treeNode_temp1.Text = obj.Appname; //Node name for view
                        treeNode_temp1.Nodes.AddRange(tempNodeL2.ToArray());	//Save level 2 apps on its respectively parent node
                        treeNode_temp1.Name = obj.Appcode;  //Node code for app caller
                        treeNode_temp1.ToolTipText = obj.Appdescr;  //Node tooltip text
                        //Set parent node as child of the next parent node and clear children node processor to avoid repeated nodes.
                        TreeNode parent1 = new TreeNode();
                        parent1.Text = obj.Appname;
                        parent1.Name = obj.Appcode;
                        parent1.ToolTipText = obj.Appdescr;
                        parent1.Nodes.AddRange(tempNodeL2.ToArray());
                        tempNodeL1.Add(parent1); tempNodeL2.Clear();
                }//END LEVEL 1 ITERATION

                //Finall add root parent nodes and its data and clear children node processor to avoid repeated nodes.
                TreeNode parent0 = new TreeNode();
                parent0.Text = app.Appname;	//Node name for view
                parent0.Name = app.Appcode;	//Node code for app caller
                parent0.ToolTipText = app.Appdescr;
                parent0.Nodes.AddRange(tempNodeL1.ToArray());
                tempNodeL0.Add(parent0); tempNodeL1.Clear();


                //Set new tree model
                this.deskapp_appMenuTree.Nodes.Clear();
                this.deskapp_appMenuTree.Nodes.AddRange(tempNodeL0.ToArray());
                this.deskapp_appMenuTree.TabIndex = tabIndex;

            }//END LEVEL 0 ITERATION

        } 


        public deskappMain(string usrCrdntls)
        {
            InitializeComponent();
            deskapp_title_label.Text = cfg.ies_name;
            deskapp_title_env_label.Text = cfg.ies_app_env;
            this.Text = cfg.ies_name + " - " + cfg.ies_app_env;
            //Retrieve user data
            userProfile = API_Users.getUserProfileData(usrCrdntls);
            dkapps = API_Users.getUserAppPermissions(usrCrdntls);
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
                //Generate tree view
                buildAppTree(dkapps);
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

        void deskapp_appMenuTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            appTree.clickedNode(sender, e);
        }

        
    }
}
