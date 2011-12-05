namespace shellCommon.Customer
{
    partial class BudgetRequestFinder
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
            this.txtSearchQuery = new DevExpress.XtraEditors.TextEdit();
            this.grdControl = new DevExpress.XtraGrid.GridControl();
            this.grdCustomerView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchQuery.Location = new System.Drawing.Point(0, 0);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(657, 20);
            this.txtSearchQuery.TabIndex = 1;
            this.txtSearchQuery.EditValueChanged += new System.EventHandler(this.txtSearchQuery_EditValueChanged);
            this.txtSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchQuery_KeyDown);
            // 
            // grdControl
            // 
            this.grdControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControl.Location = new System.Drawing.Point(0, 0);
            this.grdControl.MainView = this.grdCustomerView;
            this.grdControl.Name = "grdControl";
            this.grdControl.Size = new System.Drawing.Size(657, 240);
            this.grdControl.TabIndex = 2;
            this.grdControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCustomerView});
            // 
            // grdCustomerView
            // 
            this.grdCustomerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colProjectName,
            this.colDate,
            this.colEmployee});
            this.grdCustomerView.GridControl = this.grdControl;
            this.grdCustomerView.Name = "grdCustomerView";
            this.grdCustomerView.OptionsBehavior.Editable = false;
            this.grdCustomerView.OptionsBehavior.ReadOnly = true;
            this.grdCustomerView.OptionsCustomization.AllowColumnMoving = false;
            this.grdCustomerView.OptionsCustomization.AllowColumnResizing = false;
            this.grdCustomerView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdCustomerView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdCustomerView.OptionsView.ShowGroupPanel = false;
            this.grdCustomerView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCustomerView_KeyDown);
            // 
            // colName
            // 
            this.colName.Caption = "Nombre del Cliente";
            this.colName.FieldName = "Customer.Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 200;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(10, 0);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 22);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Aceptar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(10, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 280);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(657, 42);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(485, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(78, 22);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOk);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(563, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(94, 22);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(657, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 240);
            this.panel3.TabIndex = 7;
            // 
            // colProjectName
            // 
            this.colProjectName.Caption = "Proyecto";
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            this.colProjectName.Width = 200;
            // 
            // colDate
            // 
            this.colDate.Caption = "Fecha";
            this.colDate.DisplayFormat.FormatString = "d";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "DateModified";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Agente";
            this.colEmployee.FieldName = "Employee.Person.FullName";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 3;
            this.colEmployee.Width = 119;
            // 
            // BudgetRequestFinder
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(677, 332);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BudgetRequestFinder";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Solicitudes de Proyecto";
            this.Shown += new System.EventHandler(this.Finder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraGrid.GridControl grdControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCustomerView;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
    }
}