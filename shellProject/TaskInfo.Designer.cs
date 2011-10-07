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
            this.grpDates = new DevExpress.XtraEditors.GroupControl();
            this.dtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblEndDate = new DevExpress.XtraEditors.LabelControl();
            this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.spinCompleteRate = new DevExpress.XtraEditors.SpinEdit();
            this.lblCompleteRate = new DevExpress.XtraEditors.LabelControl();
            this.spinDuration = new DevExpress.XtraEditors.SpinEdit();
            this.lblDuration = new DevExpress.XtraEditors.LabelControl();
            this.txtTaskName = new DevExpress.XtraEditors.TextEdit();
            this.lblTaskName = new DevExpress.XtraEditors.LabelControl();
            this.tabResources = new DevExpress.XtraTab.XtraTabPage();
            this.grdResources = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPredecessors = new DevExpress.XtraTab.XtraTabPage();
            this.grdPredecessors = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNotes = new DevExpress.XtraTab.XtraTabPage();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDates)).BeginInit();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCompleteRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskName.Properties)).BeginInit();
            this.tabResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPredecessors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPredecessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(7, 7);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.tabGeneral;
            this.TabControl.Size = new System.Drawing.Size(449, 240);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabResources,
            this.tabPredecessors,
            this.tabNotes});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.grpDates);
            this.tabGeneral.Controls.Add(this.spinCompleteRate);
            this.tabGeneral.Controls.Add(this.lblCompleteRate);
            this.tabGeneral.Controls.Add(this.spinDuration);
            this.tabGeneral.Controls.Add(this.lblDuration);
            this.tabGeneral.Controls.Add(this.txtTaskName);
            this.tabGeneral.Controls.Add(this.lblTaskName);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(442, 212);
            this.tabGeneral.Text = "General";
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
            this.spinCompleteRate.Size = new System.Drawing.Size(86, 20);
            this.spinCompleteRate.TabIndex = 5;
            // 
            // lblCompleteRate
            // 
            this.lblCompleteRate.Location = new System.Drawing.Point(257, 59);
            this.lblCompleteRate.Name = "lblCompleteRate";
            this.lblCompleteRate.Size = new System.Drawing.Size(71, 13);
            this.lblCompleteRate.TabIndex = 4;
            this.lblCompleteRate.Text = "% Completado";
            // 
            // spinDuration
            // 
            this.spinDuration.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDuration.Location = new System.Drawing.Point(90, 56);
            this.spinDuration.Name = "spinDuration";
            this.spinDuration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDuration.Size = new System.Drawing.Size(100, 20);
            this.spinDuration.TabIndex = 3;
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
            this.tabResources.Size = new System.Drawing.Size(442, 212);
            this.tabResources.Text = "Recursos";
            // 
            // grdResources
            // 
            this.grdResources.Location = new System.Drawing.Point(3, 3);
            this.grdResources.MainView = this.gridView1;
            this.grdResources.Name = "grdResources";
            this.grdResources.Size = new System.Drawing.Size(436, 200);
            this.grdResources.TabIndex = 0;
            this.grdResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdResources;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tabPredecessors
            // 
            this.tabPredecessors.Controls.Add(this.grdPredecessors);
            this.tabPredecessors.Name = "tabPredecessors";
            this.tabPredecessors.Size = new System.Drawing.Size(442, 212);
            this.tabPredecessors.Text = "Predecesoras";
            // 
            // grdPredecessors
            // 
            this.grdPredecessors.Location = new System.Drawing.Point(3, 3);
            this.grdPredecessors.MainView = this.gridView2;
            this.grdPredecessors.Name = "grdPredecessors";
            this.grdPredecessors.Size = new System.Drawing.Size(436, 200);
            this.grdPredecessors.TabIndex = 0;
            this.grdPredecessors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdPredecessors;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.memoEdit1);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(442, 212);
            this.tabNotes.Text = "Notas";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(3, 12);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(436, 197);
            this.memoEdit1.TabIndex = 0;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(205, 258);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 1;
            this.cmdDelete.Text = "Eliminar";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(291, 258);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(376, 258);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancelar";
            // 
            // TaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 293);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.TabControl);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TaskInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de la Tarea";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDates)).EndInit();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCompleteRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskName.Properties)).EndInit();
            this.tabResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPredecessors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPredecessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit spinDuration;
        private DevExpress.XtraEditors.LabelControl lblDuration;
        private DevExpress.XtraEditors.TextEdit txtTaskName;
        private DevExpress.XtraEditors.LabelControl lblTaskName;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.LabelControl lblEndDate;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraGrid.GridControl grdResources;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdPredecessors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}