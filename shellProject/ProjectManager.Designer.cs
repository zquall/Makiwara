namespace shellProject
{
    partial class ProjectManager
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditProject = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditName = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditClient = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonCreateProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonVoid = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCalendar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribProject = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTask = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribHierarchy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribLink = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.ultraGanttView1 = new Infragistics.Win.UltraWinGanttView.UltraGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGanttView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditProject,
            this.barEditName,
            this.barEditClient,
            this.barButtonCreateProject,
            this.barButtonOpen,
            this.barButtonCopy,
            this.barButtonSave,
            this.barButtonVoid,
            this.barButtonCalendar,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(982, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barEditProject
            // 
            this.barEditProject.Caption = "Proyecto";
            this.barEditProject.Edit = this.repositoryItemTextEdit1;
            this.barEditProject.Id = 3;
            this.barEditProject.Name = "barEditProject";
            this.barEditProject.Width = 100;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditName
            // 
            this.barEditName.Caption = "Nombre  ";
            this.barEditName.Edit = this.repositoryItemTextEdit2;
            this.barEditName.Id = 4;
            this.barEditName.Name = "barEditName";
            this.barEditName.Width = 300;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditClient
            // 
            this.barEditClient.Caption = "Cliente   ";
            this.barEditClient.Edit = this.repositoryItemTextEdit3;
            this.barEditClient.Id = 5;
            this.barEditClient.Name = "barEditClient";
            this.barEditClient.Width = 300;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // barButtonCreateProject
            // 
            this.barButtonCreateProject.Caption = "Nuevo";
            this.barButtonCreateProject.Id = 7;
            this.barButtonCreateProject.Name = "barButtonCreateProject";
            this.barButtonCreateProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonOpen
            // 
            this.barButtonOpen.Caption = "Abrir";
            this.barButtonOpen.Id = 8;
            this.barButtonOpen.Name = "barButtonOpen";
            // 
            // barButtonCopy
            // 
            this.barButtonCopy.Caption = "Copiar";
            this.barButtonCopy.Id = 9;
            this.barButtonCopy.Name = "barButtonCopy";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "Guardar";
            this.barButtonSave.Id = 10;
            this.barButtonSave.Name = "barButtonSave";
            // 
            // barButtonVoid
            // 
            this.barButtonVoid.Caption = "Anular";
            this.barButtonVoid.Id = 11;
            this.barButtonVoid.Name = "barButtonVoid";
            // 
            // barButtonCalendar
            // 
            this.barButtonCalendar.Caption = "Calendario";
            this.barButtonCalendar.Id = 12;
            this.barButtonCalendar.Name = "barButtonCalendar";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Nueva Tarea";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Eliminar Tarea";
            this.barButtonItem8.Id = 14;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Repositorio Recursos";
            this.barButtonItem9.Id = 15;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Aplicar Sangría";
            this.barButtonItem10.Id = 16;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Anular Sangría";
            this.barButtonItem11.Id = 17;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Vincular Tareas";
            this.barButtonItem12.Id = 18;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Desvincular Tareas";
            this.barButtonItem13.Id = 19;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribProject,
            this.ribTask,
            this.ribHierarchy,
            this.ribLink,
            this.ribData});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Principal";
            // 
            // ribProject
            // 
            this.ribProject.ItemLinks.Add(this.barButtonCreateProject);
            this.ribProject.ItemLinks.Add(this.barButtonOpen);
            this.ribProject.ItemLinks.Add(this.barButtonCopy);
            this.ribProject.ItemLinks.Add(this.barButtonSave);
            this.ribProject.ItemLinks.Add(this.barButtonVoid);
            this.ribProject.ItemLinks.Add(this.barButtonCalendar);
            this.ribProject.Name = "ribProject";
            this.ribProject.Text = "Proyecto";
            // 
            // ribTask
            // 
            this.ribTask.ItemLinks.Add(this.barButtonItem7);
            this.ribTask.ItemLinks.Add(this.barButtonItem8);
            this.ribTask.ItemLinks.Add(this.barButtonItem9);
            this.ribTask.Name = "ribTask";
            this.ribTask.Text = "Tareas";
            // 
            // ribHierarchy
            // 
            this.ribHierarchy.ItemLinks.Add(this.barButtonItem10);
            this.ribHierarchy.ItemLinks.Add(this.barButtonItem11);
            this.ribHierarchy.Name = "ribHierarchy";
            this.ribHierarchy.Text = "Jerarquía";
            // 
            // ribLink
            // 
            this.ribLink.ItemLinks.Add(this.barButtonItem12);
            this.ribLink.ItemLinks.Add(this.barButtonItem13);
            this.ribLink.Name = "ribLink";
            this.ribLink.Text = "Vincular";
            // 
            // ribData
            // 
            this.ribData.ItemLinks.Add(this.barEditProject);
            this.ribData.ItemLinks.Add(this.barEditName);
            this.ribData.ItemLinks.Add(this.barEditClient);
            this.ribData.Name = "ribData";
            this.ribData.Text = "Datos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Reportes";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 470);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(982, 25);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.ultraGanttView1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(982, 327);
            this.clientPanel.TabIndex = 2;
            // 
            // ultraGanttView1
            // 
            this.ultraGanttView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGanttView1.GridAreaWidth = 287;
            this.ultraGanttView1.Location = new System.Drawing.Point(0, 0);
            this.ultraGanttView1.Name = "ultraGanttView1";
            this.ultraGanttView1.Size = new System.Drawing.Size(982, 327);
            this.ultraGanttView1.TabIndex = 0;
            this.ultraGanttView1.Text = "ultraGanttView1";
            this.ultraGanttView1.VerticalSplitterMinimumResizeWidth = 10;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 495);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ProjectManager";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Administrador de Proyectos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGanttView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribProject;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTask;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribHierarchy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribLink;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribData;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarEditItem barEditProject;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem barEditClient;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private Infragistics.Win.UltraWinGanttView.UltraGanttView ultraGanttView1;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateProject;
        private DevExpress.XtraBars.BarButtonItem barButtonOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonCopy;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonVoid;
        private DevExpress.XtraBars.BarButtonItem barButtonCalendar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
    }
}