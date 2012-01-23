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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditProject = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProject = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditName = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProjectName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditClient = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCustumer = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonCreateProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonVoid = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCalendar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNewTask = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDeleteTask = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMoveRight = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMoveLeft = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLinkTask = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUnlinkTask = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribProject = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTask = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribHierarchy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribLink = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.projectGantt = new Infragistics.Win.UltraWinGanttView.UltraGanttView();
            this.ultraCalendarInfo = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(this.components);
            this.ultraCalendarLook = new Infragistics.Win.UltraWinSchedule.UltraCalendarLook(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGantt)).BeginInit();
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
            this.barButtonNewTask,
            this.barButtonDeleteTask,
            this.barButtonItem9,
            this.barButtonMoveRight,
            this.barButtonMoveLeft,
            this.barButtonLinkTask,
            this.barButtonUnlinkTask});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProject,
            this.repositoryItemProjectName,
            this.repositoryItemCustumer});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(982, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barEditProject
            // 
            this.barEditProject.Caption = "Proyecto";
            this.barEditProject.Edit = this.repositoryItemProject;
            this.barEditProject.Id = 3;
            this.barEditProject.Name = "barEditProject";
            this.barEditProject.Width = 100;
            // 
            // repositoryItemProject
            // 
            this.repositoryItemProject.AutoHeight = false;
            this.repositoryItemProject.Name = "repositoryItemProject";
            // 
            // barEditName
            // 
            this.barEditName.Caption = "Nombre  ";
            this.barEditName.Edit = this.repositoryItemProjectName;
            this.barEditName.Id = 4;
            this.barEditName.Name = "barEditName";
            this.barEditName.Width = 300;
            // 
            // repositoryItemProjectName
            // 
            this.repositoryItemProjectName.AutoHeight = false;
            this.repositoryItemProjectName.Name = "repositoryItemProjectName";
            // 
            // barEditClient
            // 
            this.barEditClient.Caption = "Cliente   ";
            this.barEditClient.Edit = this.repositoryItemCustumer;
            this.barEditClient.Id = 5;
            this.barEditClient.Name = "barEditClient";
            this.barEditClient.Width = 300;
            // 
            // repositoryItemCustumer
            // 
            this.repositoryItemCustumer.AutoHeight = false;
            this.repositoryItemCustumer.Name = "repositoryItemCustumer";
            // 
            // barButtonCreateProject
            // 
            this.barButtonCreateProject.Caption = "Nuevo";
            this.barButtonCreateProject.Id = 7;
            this.barButtonCreateProject.Name = "barButtonCreateProject";
            this.barButtonCreateProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCreateProject_ItemClick);
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
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
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
            // barButtonNewTask
            // 
            this.barButtonNewTask.Caption = "Nueva Tarea";
            this.barButtonNewTask.Id = 13;
            this.barButtonNewTask.Name = "barButtonNewTask";
            this.barButtonNewTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNewTask_ItemClick);
            // 
            // barButtonDeleteTask
            // 
            this.barButtonDeleteTask.Caption = "Eliminar Tarea";
            this.barButtonDeleteTask.Id = 14;
            this.barButtonDeleteTask.Name = "barButtonDeleteTask";
            this.barButtonDeleteTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDeleteTask_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Repositorio Recursos";
            this.barButtonItem9.Id = 15;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonMoveRight
            // 
            this.barButtonMoveRight.Caption = "Aplicar Sangría";
            this.barButtonMoveRight.Id = 16;
            this.barButtonMoveRight.Name = "barButtonMoveRight";
            this.barButtonMoveRight.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMoveRight_ItemClick);
            // 
            // barButtonMoveLeft
            // 
            this.barButtonMoveLeft.Caption = "Anular Sangría";
            this.barButtonMoveLeft.Id = 17;
            this.barButtonMoveLeft.Name = "barButtonMoveLeft";
            this.barButtonMoveLeft.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMoveLeft_ItemClick);
            // 
            // barButtonLinkTask
            // 
            this.barButtonLinkTask.Caption = "Vincular Tareas";
            this.barButtonLinkTask.Id = 18;
            this.barButtonLinkTask.Name = "barButtonLinkTask";
            this.barButtonLinkTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLinkTask_ItemClick);
            // 
            // barButtonUnlinkTask
            // 
            this.barButtonUnlinkTask.Caption = "Desvincular Tareas";
            this.barButtonUnlinkTask.Id = 19;
            this.barButtonUnlinkTask.Name = "barButtonUnlinkTask";
            this.barButtonUnlinkTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUnlinkTask_ItemClick);
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
            this.ribTask.ItemLinks.Add(this.barButtonNewTask);
            this.ribTask.ItemLinks.Add(this.barButtonDeleteTask);
            this.ribTask.ItemLinks.Add(this.barButtonItem9);
            this.ribTask.Name = "ribTask";
            this.ribTask.Text = "Tareas";
            // 
            // ribHierarchy
            // 
            this.ribHierarchy.ItemLinks.Add(this.barButtonMoveRight);
            this.ribHierarchy.ItemLinks.Add(this.barButtonMoveLeft);
            this.ribHierarchy.Name = "ribHierarchy";
            this.ribHierarchy.Text = "Jerarquía";
            // 
            // ribLink
            // 
            this.ribLink.ItemLinks.Add(this.barButtonLinkTask);
            this.ribLink.ItemLinks.Add(this.barButtonUnlinkTask);
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
            this.ribData.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.ribData_CaptionButtonClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Reportes";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 472);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(982, 23);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.projectGantt);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 148);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(982, 324);
            this.clientPanel.TabIndex = 2;
            // 
            // projectGantt
            // 
            this.projectGantt.CalendarInfo = this.ultraCalendarInfo;
            this.projectGantt.CalendarLook = this.ultraCalendarLook;
            this.projectGantt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectGantt.GridAreaWidth = 500;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Dependencies).Text = "Dependencias";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Dependencies).Width = 80;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Duration).Text = "Duración";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Duration).Width = 50;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.EndDateTime).Text = "Fin";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.EndDateTime).Width = 70;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Name).Text = "Nombre";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Name).Width = 100;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Notes).Text = "Notas";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.PercentComplete).Text = "% Completado";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.PercentComplete).Visible = Infragistics.Win.DefaultableBoolean.True;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Resources).Text = "Recursos";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.Resources).Visible = Infragistics.Win.DefaultableBoolean.False;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.StartDateTime).Text = "Incio";
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.StartDateTime).Width = 70;
            this.projectGantt.GridSettings.ColumnSettings.GetValue(Infragistics.Win.UltraWinSchedule.TaskField.RowNumber).Text = "#";
            this.projectGantt.Location = new System.Drawing.Point(0, 0);
            this.projectGantt.Name = "projectGantt";
            this.projectGantt.Size = new System.Drawing.Size(982, 324);
            this.projectGantt.TabIndex = 0;
            this.projectGantt.Text = "ultraGanttView1";
            this.projectGantt.VerticalSplitterMinimumResizeWidth = 10;
            this.projectGantt.TaskDialogDisplaying += new Infragistics.Win.UltraWinGanttView.TaskDialogDisplayingHandler(this.projectGantt_TaskDialogDisplaying);
            this.projectGantt.ActiveTaskChanging += new Infragistics.Win.UltraWinGanttView.ActiveTaskChangingHandler(this.projectGantt_ActiveTaskChanging);
            // 
            // ultraCalendarInfo
            // 
            this.ultraCalendarInfo.DataBindingsForAppointments.BindingContextControl = this;
            this.ultraCalendarInfo.DataBindingsForOwners.BindingContextControl = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectGantt)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemProject;
        private DevExpress.XtraBars.BarEditItem barEditName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemProjectName;
        private DevExpress.XtraBars.BarEditItem barEditClient;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCustumer;
        private Infragistics.Win.UltraWinGanttView.UltraGanttView projectGantt;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateProject;
        private DevExpress.XtraBars.BarButtonItem barButtonOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonCopy;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonVoid;
        private DevExpress.XtraBars.BarButtonItem barButtonCalendar;
        private DevExpress.XtraBars.BarButtonItem barButtonNewTask;
        private DevExpress.XtraBars.BarButtonItem barButtonDeleteTask;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonMoveRight;
        private DevExpress.XtraBars.BarButtonItem barButtonMoveLeft;
        private DevExpress.XtraBars.BarButtonItem barButtonLinkTask;
        private DevExpress.XtraBars.BarButtonItem barButtonUnlinkTask;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarLook ultraCalendarLook;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}