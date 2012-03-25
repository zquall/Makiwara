namespace shellCommon.Employee
{
    partial class EmployeeFinder
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
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdControl = new DevExpress.XtraGrid.GridControl();
            this.grdControlView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryByHour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel5.TabIndex = 0;
            // 
            // cmdOk
            // 
            this.cmdOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdOk.Location = new System.Drawing.Point(10, 0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(84, 22);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.CmdOkClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdCancelar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(579, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(78, 22);
            this.panel4.TabIndex = 0;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCancelar.Location = new System.Drawing.Point(10, 0);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(68, 22);
            this.cmdCancelar.TabIndex = 0;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
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
            // 
            // grdControlView
            // 
            this.grdControlView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colSalaryByHour,
            this.colName});
            this.grdControlView.GridControl = this.grdControl;
            this.grdControlView.Name = "grdControlView";
            this.grdControlView.OptionsBehavior.Editable = false;
            this.grdControlView.OptionsBehavior.ReadOnly = true;
            this.grdControlView.OptionsCustomization.AllowColumnMoving = false;
            this.grdControlView.OptionsCustomization.AllowColumnResizing = false;
            this.grdControlView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdControlView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdControlView.OptionsView.ShowGroupPanel = false;
            this.grdControlView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdControlViewKeyDown);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "Id";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 59;
            // 
            // colCode
            // 
            this.colCode.Caption = "Código";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 123;
            // 
            // colSalaryByHour
            // 
            this.colSalaryByHour.Caption = "Salario X Hora";
            this.colSalaryByHour.DisplayFormat.FormatString = "{0:N2}";
            this.colSalaryByHour.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalaryByHour.FieldName = "SalaryByHour";
            this.colSalaryByHour.Name = "colSalaryByHour";
            this.colSalaryByHour.Visible = true;
            this.colSalaryByHour.VisibleIndex = 2;
            this.colSalaryByHour.Width = 114;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre";
            this.colName.FieldName = "Person";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 340;
            // 
            // EmployeeFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 332);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeFinder";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeFinder";
            this.Shown += new System.EventHandler(this.EmployeeFinderShown);
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraGrid.GridControl grdControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdControlView;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryByHour;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
    }
}