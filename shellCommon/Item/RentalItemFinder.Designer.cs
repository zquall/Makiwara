namespace shellCommon.Item
{
    partial class RentalItemFinder
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
            this.GrdControl = new DevExpress.XtraGrid.GridControl();
            this.GrdControlView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvailable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFortnight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeekly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControlView)).BeginInit();
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
            this.txtSearchQuery.Size = new System.Drawing.Size(856, 20);
            this.txtSearchQuery.TabIndex = 1;
            this.txtSearchQuery.EditValueChanged += new System.EventHandler(this.TxtSearchQueryEditValueChanged);
            this.txtSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchQueryKeyDown);
            // 
            // GrdControl
            // 
            this.GrdControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl.Location = new System.Drawing.Point(0, 0);
            this.GrdControl.MainView = this.GrdControlView;
            this.GrdControl.Name = "GrdControl";
            this.GrdControl.Size = new System.Drawing.Size(856, 405);
            this.GrdControl.TabIndex = 2;
            this.GrdControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdControlView});
            // 
            // GrdControlView
            // 
            this.GrdControlView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colAvailable,
            this.colMonthly,
            this.colFortnight,
            this.colWeekly,
            this.colDaily});
            this.GrdControlView.GridControl = this.GrdControl;
            this.GrdControlView.Name = "GrdControlView";
            this.GrdControlView.OptionsBehavior.Editable = false;
            this.GrdControlView.OptionsBehavior.ReadOnly = true;
            this.GrdControlView.OptionsCustomization.AllowColumnMoving = false;
            this.GrdControlView.OptionsCustomization.AllowColumnResizing = false;
            this.GrdControlView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GrdControlView.OptionsView.EnableAppearanceEvenRow = true;
            this.GrdControlView.OptionsView.ShowGroupPanel = false;
            this.GrdControlView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GrdControlViewCustomUnboundColumnData);
            this.GrdControlView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdCustomerViewKeyDown);
            // 
            // colCode
            // 
            this.colCode.Caption = "Codigo";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 115;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre del Articulo";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 300;
            // 
            // colAvailable
            // 
            this.colAvailable.Caption = "Disponible";
            this.colAvailable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAvailable.FieldName = "Available";
            this.colAvailable.Name = "colAvailable";
            this.colAvailable.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colAvailable.Visible = true;
            this.colAvailable.VisibleIndex = 2;
            this.colAvailable.Width = 80;
            // 
            // colMonthly
            // 
            this.colMonthly.Caption = "Mensual";
            this.colMonthly.DisplayFormat.FormatString = "$ #,##0.00";
            this.colMonthly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMonthly.FieldName = "MonthlyPrice";
            this.colMonthly.Name = "colMonthly";
            this.colMonthly.Visible = true;
            this.colMonthly.VisibleIndex = 3;
            this.colMonthly.Width = 110;
            // 
            // colFortnight
            // 
            this.colFortnight.Caption = "Quincenal";
            this.colFortnight.DisplayFormat.FormatString = "$ #,##0.00";
            this.colFortnight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFortnight.FieldName = "FortnightPrice";
            this.colFortnight.Name = "colFortnight";
            this.colFortnight.Visible = true;
            this.colFortnight.VisibleIndex = 4;
            // 
            // colWeekly
            // 
            this.colWeekly.Caption = "Semanal";
            this.colWeekly.DisplayFormat.FormatString = "$ #,##0.00";
            this.colWeekly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeekly.FieldName = "WeeklyPrice";
            this.colWeekly.Name = "colWeekly";
            this.colWeekly.Visible = true;
            this.colWeekly.VisibleIndex = 5;
            // 
            // colDaily
            // 
            this.colDaily.Caption = "Diario";
            this.colDaily.DisplayFormat.FormatString = "$ #,##0.00";
            this.colDaily.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDaily.FieldName = "DailyPrice";
            this.colDaily.Name = "colDaily";
            this.colDaily.Visible = true;
            this.colDaily.VisibleIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(9, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(9, 0);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 22);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Aceptar";
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 447);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(856, 42);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOk);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(651, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(105, 22);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(756, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(100, 22);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(856, 32);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GrdControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(856, 405);
            this.panel3.TabIndex = 7;
            // 
            // RentalItemFinder
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RentalItemFinder";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Equipo de Alquiler";
            this.Shown += new System.EventHandler(this.FinderShown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControlView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraGrid.GridControl GrdControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdControlView;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthly;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailable;
        private DevExpress.XtraGrid.Columns.GridColumn colFortnight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeekly;
        private DevExpress.XtraGrid.Columns.GridColumn colDaily;
    }
}