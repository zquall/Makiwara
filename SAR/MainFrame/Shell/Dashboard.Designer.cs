namespace MainFrame.Shell
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.navBarControlDashboard = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupProject = new DevExpress.XtraNavBar.NavBarGroup();
            this.themeManager = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControlDashboard
            // 
            this.navBarControlDashboard.ActiveGroup = this.navBarGroupProject;
            this.navBarControlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlDashboard.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupProject});
            this.navBarControlDashboard.Location = new System.Drawing.Point(0, 0);
            this.navBarControlDashboard.Name = "navBarControlDashboard";
            this.navBarControlDashboard.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControlDashboard.Size = new System.Drawing.Size(164, 573);
            this.navBarControlDashboard.TabIndex = 0;
            this.navBarControlDashboard.Text = "DashBoard";
            this.navBarControlDashboard.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Black");
            this.navBarControlDashboard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlDashboard_LinkClicked);
            // 
            // navBarGroupProject
            // 
            this.navBarGroupProject.Caption = "Proyectos";
            this.navBarGroupProject.Expanded = true;
            this.navBarGroupProject.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupProject.LargeImage")));
            this.navBarGroupProject.Name = "navBarGroupProject";
            // 
            // themeManager
            // 
            this.themeManager.LookAndFeel.SkinName = "Black";
            // 
            // MdiManager
            // 
            this.MdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.MdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.MdiManager.MdiParent = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 573);
            this.Controls.Add(this.navBarControlDashboard);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Dashboard";
            this.Text = "Sistema Administrativo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControlDashboard;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupProject;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themeManager;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
    }
}