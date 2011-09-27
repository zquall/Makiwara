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
            this.components = new System.ComponentModel.Container();
            this.navBarControlDashboard = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupProject = new DevExpress.XtraNavBar.NavBarGroup();
            this.themeManager = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
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
            this.navBarControlDashboard.Size = new System.Drawing.Size(140, 497);
            this.navBarControlDashboard.TabIndex = 0;
            this.navBarControlDashboard.Text = "DashBoard";
            this.navBarControlDashboard.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Black");
            // 
            // navBarGroupProject
            // 
            this.navBarGroupProject.Caption = "Proyectos";
            this.navBarGroupProject.Expanded = true;
            this.navBarGroupProject.LargeImage = global::MainFrame.Shell.Properties.Resources.ico_project;
            this.navBarGroupProject.Name = "navBarGroupProject";
            // 
            // themeManager
            // 
            this.themeManager.LookAndFeel.SkinName = "Black";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 497);
            this.Controls.Add(this.navBarControlDashboard);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Sistema Administrativo";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControlDashboard;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupProject;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themeManager;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}