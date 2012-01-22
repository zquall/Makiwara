namespace shellProject
{
    partial class TaskInfo
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
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.drtDuration = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.grpDates = new DevExpress.XtraEditors.GroupControl();
            this.dtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblEndDate = new DevExpress.XtraEditors.LabelControl();
            this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.spinCompleteRate = new DevExpress.XtraEditors.SpinEdit();
            this.lblCompleteRate = new DevExpress.XtraEditors.LabelControl();
            this.lblDuration = new DevExpress.XtraEditors.LabelControl();
            this.txtTaskName = new DevExpress.XtraEditors.TextEdit();
            this.lblTaskName = new DevExpress.XtraEditors.LabelControl();
            this.tabResources = new DevExpress.XtraTab.XtraTabPage();
            this.grdResources = new DevExpress.XtraGrid.GridControl();
            this.viewResources = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repResourceTypes = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repMeasures = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repResourceCode = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabPredecessors = new DevExpress.XtraTab.XtraTabPage();
            this.grdPredecessors = new DevExpress.XtraGrid.GridControl();
            this.viewDependencies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNotes = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditNotes = new DevExpress.XtraEditors.MemoEdit();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drtDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDates)).BeginInit();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCompleteRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskName.Properties)).BeginInit();
            this.tabResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repResourceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repResourceCode)).BeginInit();
            this.tabPredecessors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPredecessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDependencies)).BeginInit();
            this.tabNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNotes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(7, 7);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.tabGeneral;
            this.TabControl.Size = new System.Drawing.Size(610, 240);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabResources,
            this.tabPredecessors,
            this.tabNotes});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.drtDuration);
            this.tabGeneral.Controls.Add(this.grpDates);
            this.tabGeneral.Controls.Add(this.spinCompleteRate);
            this.tabGeneral.Controls.Add(this.lblCompleteRate);
            this.tabGeneral.Controls.Add(this.lblDuration);
            this.tabGeneral.Controls.Add(this.txtTaskName);
            this.tabGeneral.Controls.Add(this.lblTaskName);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(603, 212);
            this.tabGeneral.Text = "General";
            // 
            // drtDuration
            // 
            this.drtDuration.Location = new System.Drawing.Point(90, 56);
            this.drtDuration.Name = "drtDuration";
            this.drtDuration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drtDuration.Properties.Items.AddRange(new object[] {
            System.TimeSpan.Parse("00:00:00"),
            System.TimeSpan.Parse("1.00:00:00"),
            System.TimeSpan.Parse("2.00:00:00"),
            System.TimeSpan.Parse("3.00:00:00"),
            System.TimeSpan.Parse("4.00:00:00"),
            System.TimeSpan.Parse("5.00:00:00"),
            System.TimeSpan.Parse("6.00:00:00"),
            System.TimeSpan.Parse("7.00:00:00"),
            System.TimeSpan.Parse("8.00:00:00"),
            System.TimeSpan.Parse("9.00:00:00"),
            System.TimeSpan.Parse("10.00:00:00"),
            System.TimeSpan.Parse("11.00:00:00"),
            System.TimeSpan.Parse("12.00:00:00"),
            System.TimeSpan.Parse("13.00:00:00"),
            System.TimeSpan.Parse("14.00:00:00")});
            this.drtDuration.Size = new System.Drawing.Size(100, 20);
            this.drtDuration.TabIndex = 7;
            this.drtDuration.TextChanged += new System.EventHandler(this.drtDuration_TextChanged);
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dtEndDate);
            this.grpDates.Controls.Add(this.lblEndDate);
            this.grpDates.Controls.Add(this.dtStartDate);
            this.grpDates.Controls.Add(this.lblStartDate);
            this.grpDates.Location = new System.Drawing.Point(22, 96);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(398, 100);
            this.grpDates.TabIndex = 6;
            this.grpDates.Text = "Fechas";
            // 
            // dtEndDate
            // 
            this.dtEndDate.EditValue = null;
            this.dtEndDate.Location = new System.Drawing.Point(235, 54);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtEndDate.TabIndex = 3;
            this.dtEndDate.EditValueChanged += new System.EventHandler(this.dtEndDate_EditValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(261, 35);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Fecha Final";
            // 
            // dtStartDate
            // 
            this.dtStartDate.EditValue = null;
            this.dtStartDate.Location = new System.Drawing.Point(51, 54);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.EditValueChanged += new System.EventHandler(this.dtStartDate_EditValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(68, 35);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Fecha de Inicio";
            // 
            // spinCompleteRate
            // 
            this.spinCompleteRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCompleteRate.Location = new System.Drawing.Point(334, 56);
            this.spinCompleteRate.Name = "spinCompleteRate";
            this.spinCompleteRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCompleteRate.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinCompleteRate.Size = new System.Drawing.Size(86, 20);
            this.spinCompleteRate.TabIndex = 5;
            this.spinCompleteRate.EditValueChanged += new System.EventHandler(this.spinCompleteRate_EditValueChanged);
            this.spinCompleteRate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spinCompleteRate_EditValueChanging);
            // 
            // lblCompleteRate
            // 
            this.lblCompleteRate.Location = new System.Drawing.Point(257, 59);
            this.lblCompleteRate.Name = "lblCompleteRate";
            this.lblCompleteRate.Size = new System.Drawing.Size(71, 13);
            this.lblCompleteRate.TabIndex = 4;
            this.lblCompleteRate.Text = "% Completado";
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(22, 59);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(42, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duración";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(90, 17);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(330, 20);
            this.txtTaskName.TabIndex = 1;
            this.txtTaskName.EditValueChanged += new System.EventHandler(this.txtTaskName_EditValueChanged);
            // 
            // lblTaskName
            // 
            this.lblTaskName.Location = new System.Drawing.Point(22, 20);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(37, 13);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Nombre";
            // 
            // tabResources
            // 
            this.tabResources.Controls.Add(this.grdResources);
            this.tabResources.Name = "tabResources";
            this.tabResources.Size = new System.Drawing.Size(603, 212);
            this.tabResources.Text = "Recursos";
            // 
            // grdResources
            // 
            this.grdResources.Location = new System.Drawing.Point(3, 3);
            this.grdResources.MainView = this.viewResources;
            this.grdResources.Name = "grdResources";
            this.grdResources.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repResourceTypes,
            this.repMeasures,
            this.repResourceCode});
            this.grdResources.Size = new System.Drawing.Size(598, 200);
            this.grdResources.TabIndex = 0;
            this.grdResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewResources});
            // 
            // viewResources
            // 
            this.viewResources.GridControl = this.grdResources;
            this.viewResources.Name = "viewResources";
            this.viewResources.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.viewResources.OptionsView.ShowGroupPanel = false;
            this.viewResources.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.viewResources_InitNewRow);
            // 
            // repResourceTypes
            // 
            this.repResourceTypes.AutoHeight = false;
            this.repResourceTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repResourceTypes.Name = "repResourceTypes";
            // 
            // repMeasures
            // 
            this.repMeasures.AutoHeight = false;
            this.repMeasures.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repMeasures.Name = "repMeasures";
            // 
            // repResourceCode
            // 
            this.repResourceCode.AutoHeight = false;
            this.repResourceCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repResourceCode.Name = "repResourceCode";
            this.repResourceCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repResourceCode_ButtonClick);
            // 
            // tabPredecessors
            // 
            this.tabPredecessors.Controls.Add(this.grdPredecessors);
            this.tabPredecessors.Name = "tabPredecessors";
            this.tabPredecessors.Size = new System.Drawing.Size(603, 212);
            this.tabPredecessors.Text = "Predecesoras";
            // 
            // grdPredecessors
            // 
            this.grdPredecessors.Location = new System.Drawing.Point(3, 3);
            this.grdPredecessors.MainView = this.viewDependencies;
            this.grdPredecessors.Name = "grdPredecessors";
            this.grdPredecessors.Size = new System.Drawing.Size(597, 200);
            this.grdPredecessors.TabIndex = 0;
            this.grdPredecessors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDependencies});
            // 
            // viewDependencies
            // 
            this.viewDependencies.GridControl = this.grdPredecessors;
            this.viewDependencies.Name = "viewDependencies";
            this.viewDependencies.OptionsView.ShowGroupPanel = false;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.memoEditNotes);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(603, 212);
            this.tabNotes.Text = "Notas";
            // 
            // memoEditNotes
            // 
            this.memoEditNotes.Location = new System.Drawing.Point(3, 12);
            this.memoEditNotes.Name = "memoEditNotes";
            this.memoEditNotes.Size = new System.Drawing.Size(597, 197);
            this.memoEditNotes.TabIndex = 0;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(366, 258);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 1;
            this.cmdDelete.Text = "Eliminar";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(452, 258);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(537, 258);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // TaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 293);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.TabControl);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TaskInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de la Tarea";
            this.Load += new System.EventHandler(this.TaskInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drtDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDates)).EndInit();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCompleteRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskName.Properties)).EndInit();
            this.tabResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repResourceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repResourceCode)).EndInit();
            this.tabPredecessors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPredecessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDependencies)).EndInit();
            this.tabNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNotes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage tabGeneral;
        private DevExpress.XtraTab.XtraTabPage tabResources;
        private DevExpress.XtraTab.XtraTabPage tabPredecessors;
        private DevExpress.XtraTab.XtraTabPage tabNotes;
        private DevExpress.XtraEditors.GroupControl grpDates;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DevExpress.XtraEditors.SpinEdit spinCompleteRate;
        private DevExpress.XtraEditors.LabelControl lblCompleteRate;
        private DevExpress.XtraEditors.LabelControl lblDuration;
        private DevExpress.XtraEditors.TextEdit txtTaskName;
        private DevExpress.XtraEditors.LabelControl lblTaskName;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.LabelControl lblEndDate;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraGrid.GridControl grdResources;
        private DevExpress.XtraGrid.Views.Grid.GridView viewResources;
        private DevExpress.XtraGrid.GridControl grdPredecessors;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDependencies;
        private DevExpress.XtraEditors.MemoEdit memoEditNotes;
        private DevExpress.XtraScheduler.UI.DurationEdit drtDuration;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repResourceTypes;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repMeasures;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repResourceCode;
    }
}