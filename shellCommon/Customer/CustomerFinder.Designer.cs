namespace shellCommon.Customer
{
    partial class CustomerFinder
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearchQuery = new DevExpress.XtraEditors.TextEdit();
            this.grdCustomerControl = new DevExpress.XtraGrid.GridControl();
            this.grdCustomerView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewCustomer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(223, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Escriba el nombre del cliente que desea buscar";
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Location = new System.Drawing.Point(12, 31);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(568, 20);
            this.txtSearchQuery.TabIndex = 1;
            this.txtSearchQuery.EditValueChanged += new System.EventHandler(this.txtSearchQuery_EditValueChanged);
            // 
            // grdCustomerControl
            // 
            this.grdCustomerControl.Location = new System.Drawing.Point(12, 57);
            this.grdCustomerControl.MainView = this.grdCustomerView;
            this.grdCustomerControl.Name = "grdCustomerControl";
            this.grdCustomerControl.Size = new System.Drawing.Size(568, 172);
            this.grdCustomerControl.TabIndex = 2;
            this.grdCustomerControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCustomerView});
            // 
            // grdCustomerView
            // 
            this.grdCustomerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.grdCustomerView.GridControl = this.grdCustomerControl;
            this.grdCustomerView.Name = "grdCustomerView";
            this.grdCustomerView.OptionsBehavior.Editable = false;
            this.grdCustomerView.OptionsBehavior.ReadOnly = true;
            this.grdCustomerView.OptionsCustomization.AllowColumnMoving = false;
            this.grdCustomerView.OptionsCustomization.AllowColumnResizing = false;
            this.grdCustomerView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdCustomerView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdCustomerView.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre del Cliente";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(424, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Aceptar";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(505, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 239);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(139, 23);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "Agregar Cliente Nuevo";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // CustomerFinder
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(592, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grdCustomerControl);
            this.Controls.Add(this.txtSearchQuery);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Cliente";
            this.Shown += new System.EventHandler(this.CustomerFinder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraGrid.GridControl grdCustomerControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCustomerView;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.SimpleButton btnNewCustomer;
    }
}