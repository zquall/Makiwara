namespace shellCommon.Employee
{
    partial class PostFinder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchQuery = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdControl = new DevExpress.XtraGrid.GridControl();
            this.grdControlView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstimatedSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 30);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchQuery.Location = new System.Drawing.Point(0, 0);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(657, 20);
            this.txtSearchQuery.TabIndex = 0;
            this.txtSearchQuery.EditValueChanged += new System.EventHandler(this.TxtSearchQueryEditValueChanged);
            this.txtSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchQueryKeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 280);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(657, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmdOk);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(485, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(94, 22);
            this.panel5.TabIndex = 1;
            // 
            // cmdOk
            // 
            this.cmdOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdOk.Location = new System.Drawing.Point(10, 0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(84, 22);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.CmdOkClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(579, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(78, 22);
            this.panel4.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdClose.Location = new System.Drawing.Point(10, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(68, 22);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.CmdCloseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 240);
            this.panel3.TabIndex = 2;
            // 
            // grdControl
            // 
            this.grdControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControl.Location = new System.Drawing.Point(0, 0);
            this.grdControl.MainView = this.grdControlView;
            this.grdControl.Name = "grdControl";
            this.grdControl.Size = new System.Drawing.Size(657, 240);
            this.grdControl.TabIndex = 0;
            this.grdControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdControlView});
            this.grdControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdControlKeyDown);
            // 
            // grdControlView
            // 
            this.grdControlView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colEstimatedSalary});
            this.grdControlView.GridControl = this.grdControl;
            this.grdControlView.Name = "grdControlView";
            this.grdControlView.OptionsBehavior.Editable = false;
            this.grdControlView.OptionsBehavior.ReadOnly = true;
            this.grdControlView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdControlView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdControlView.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre del Puesto";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 391;
            // 
            // colEstimatedSalary
            // 
            this.colEstimatedSalary.Caption = "Salario Estimado";
            this.colEstimatedSalary.FieldName = "EstimatedSalary";
            this.colEstimatedSalary.Name = "colEstimatedSalary";
            this.colEstimatedSalary.Visible = true;
            this.colEstimatedSalary.VisibleIndex = 1;
            this.colEstimatedSalary.Width = 245;
            // 
            // PostFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 332);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PostFinder";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "PostFinder";
            this.Shown += new System.EventHandler(this.PostFinderShown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraGrid.GridControl grdControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdControlView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEstimatedSalary;
    }
}