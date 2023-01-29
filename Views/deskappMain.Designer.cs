namespace ies_admin_academ.Views
{
    partial class deskappMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Aplicaciones");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Periodos");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Matrículas");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Periodo");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Egresados");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Certificados", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Histórico pagos");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Validar pagos");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Anular pago/factura");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Autorizar pago");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Pagos", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Asignaturas");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Financieras");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Grado");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Permisos matrícula");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Reingresos/Transferencias");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Solicitudes");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Estudiantes", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Académia", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode30,
            treeNode35,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Buscar empleado");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Recurso humano", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Administración", new System.Windows.Forms.TreeNode[] {
            treeNode45});
            this.deskapp_bottom_statusbar = new System.Windows.Forms.StatusStrip();
            this.deskapp_bottom_statusbar_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.deskapp_upper_menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deskapp_title_label = new System.Windows.Forms.Label();
            this.deskapp_title_env_label = new System.Windows.Forms.Label();
            this.deskapp_appMenuTree = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.deskapp_bottom_statusbar.SuspendLayout();
            this.deskapp_upper_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // deskapp_bottom_statusbar
            // 
            this.deskapp_bottom_statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deskapp_bottom_statusbar_label});
            this.deskapp_bottom_statusbar.Location = new System.Drawing.Point(0, 564);
            this.deskapp_bottom_statusbar.Name = "deskapp_bottom_statusbar";
            this.deskapp_bottom_statusbar.Size = new System.Drawing.Size(1008, 22);
            this.deskapp_bottom_statusbar.TabIndex = 0;
            this.deskapp_bottom_statusbar.Text = "statusStrip1";
            // 
            // deskapp_bottom_statusbar_label
            // 
            this.deskapp_bottom_statusbar_label.Name = "deskapp_bottom_statusbar_label";
            this.deskapp_bottom_statusbar_label.Size = new System.Drawing.Size(118, 17);
            this.deskapp_bottom_statusbar_label.Text = "toolStripStatusLabel1";
            // 
            // deskapp_upper_menu
            // 
            this.deskapp_upper_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.deskapp_upper_menu.Location = new System.Drawing.Point(0, 0);
            this.deskapp_upper_menu.Name = "deskapp_upper_menu";
            this.deskapp_upper_menu.Size = new System.Drawing.Size(1008, 24);
            this.deskapp_upper_menu.TabIndex = 1;
            this.deskapp_upper_menu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelSoftwareToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // acercaDelSoftwareToolStripMenuItem
            // 
            this.acercaDelSoftwareToolStripMenuItem.Name = "acercaDelSoftwareToolStripMenuItem";
            this.acercaDelSoftwareToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.acercaDelSoftwareToolStripMenuItem.Text = "Acerca del software";
            // 
            // deskapp_title_label
            // 
            this.deskapp_title_label.AutoSize = true;
            this.deskapp_title_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deskapp_title_label.Location = new System.Drawing.Point(12, 33);
            this.deskapp_title_label.Name = "deskapp_title_label";
            this.deskapp_title_label.Size = new System.Drawing.Size(110, 45);
            this.deskapp_title_label.TabIndex = 2;
            this.deskapp_title_label.Text = "label1";
            // 
            // deskapp_title_env_label
            // 
            this.deskapp_title_env_label.AutoSize = true;
            this.deskapp_title_env_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deskapp_title_env_label.Location = new System.Drawing.Point(13, 87);
            this.deskapp_title_env_label.Name = "deskapp_title_env_label";
            this.deskapp_title_env_label.Size = new System.Drawing.Size(65, 25);
            this.deskapp_title_env_label.TabIndex = 3;
            this.deskapp_title_env_label.Text = "label1";
            // 
            // deskapp_appMenuTree
            // 
            this.deskapp_appMenuTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deskapp_appMenuTree.Location = new System.Drawing.Point(12, 141);
            this.deskapp_appMenuTree.Name = "deskapp_appMenuTree";
            treeNode24.Name = "Nodo1";
            treeNode24.Text = "Aplicaciones";
            treeNode25.Name = "Nodo2";
            treeNode25.Text = "Periodos";
            treeNode26.Name = "Nodo3";
            treeNode26.Text = "Matrículas";
            treeNode27.Name = "Nodo5";
            treeNode27.Text = "General";
            treeNode28.Name = "Nodo6";
            treeNode28.Text = "Periodo";
            treeNode29.Name = "Nodo7";
            treeNode29.Text = "Egresados";
            treeNode30.Name = "Nodo4";
            treeNode30.Text = "Certificados";
            treeNode31.Name = "Nodo9";
            treeNode31.Text = "Histórico pagos";
            treeNode32.Name = "Nodo10";
            treeNode32.Text = "Validar pagos";
            treeNode33.Name = "Nodo11";
            treeNode33.Text = "Anular pago/factura";
            treeNode34.Name = "Nodo12";
            treeNode34.Text = "Autorizar pago";
            treeNode35.Name = "Nodo8";
            treeNode35.Text = "Pagos";
            treeNode36.Name = "Nodo14";
            treeNode36.Text = "Asignaturas";
            treeNode37.Name = "Nodo15";
            treeNode37.Text = "Financieras";
            treeNode38.Name = "Nodo16";
            treeNode38.Text = "Grado";
            treeNode39.Name = "Nodo17";
            treeNode39.Text = "Permisos matrícula";
            treeNode40.Name = "Nodo18";
            treeNode40.Text = "Reingresos/Transferencias";
            treeNode41.Name = "Nodo19";
            treeNode41.Text = "Solicitudes";
            treeNode42.Name = "Nodo13";
            treeNode42.Text = "Estudiantes";
            treeNode43.Name = "Nodo0";
            treeNode43.Text = "Académia";
            treeNode44.Name = "Nodo22";
            treeNode44.Text = "Buscar empleado";
            treeNode45.Name = "Nodo21";
            treeNode45.Text = "Recurso humano";
            treeNode46.Name = "Nodo20";
            treeNode46.Text = "Administración";
            this.deskapp_appMenuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode46});
            this.deskapp_appMenuTree.Size = new System.Drawing.Size(984, 420);
            this.deskapp_appMenuTree.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Realice doble click sobre el aplicativo que desee usar";
            // 
            // deskappMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deskapp_appMenuTree);
            this.Controls.Add(this.deskapp_title_env_label);
            this.Controls.Add(this.deskapp_title_label);
            this.Controls.Add(this.deskapp_bottom_statusbar);
            this.Controls.Add(this.deskapp_upper_menu);
            this.MainMenuStrip = this.deskapp_upper_menu;
            this.MinimumSize = new System.Drawing.Size(1024, 625);
            this.Name = "deskappMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deskappMain";
            this.deskapp_bottom_statusbar.ResumeLayout(false);
            this.deskapp_bottom_statusbar.PerformLayout();
            this.deskapp_upper_menu.ResumeLayout(false);
            this.deskapp_upper_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public StatusStrip deskapp_bottom_statusbar;
        public ToolStripStatusLabel deskapp_bottom_statusbar_label;
        public MenuStrip deskapp_upper_menu;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem acercaDelSoftwareToolStripMenuItem;
        public Label deskapp_title_label;
        private TreeView deskapp_appMenuTree;
        private Label label2;
        public Label deskapp_title_env_label;
    }
}