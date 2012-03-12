namespace shellProject
{
    partial class Calendar
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
            this.spinDaysXMonth = new DevExpress.XtraEditors.SpinEdit();
            this.lblDaysXMonth = new DevExpress.XtraEditors.LabelControl();
            this.spinWorkweek = new DevExpress.XtraEditors.SpinEdit();
            this.lblWorkweek = new DevExpress.XtraEditors.LabelControl();
            this.spinWorkday = new DevExpress.XtraEditors.SpinEdit();
            this.lblWorkday = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartureTime = new DevExpress.XtraEditors.TextEdit();
            this.lblDepartureTime = new DevExpress.XtraEditors.LabelControl();
            this.txtCheck = new DevExpress.XtraEditors.TextEdit();
            this.lblCheck = new DevExpress.XtraEditors.LabelControl();
            this.cmbBeginDay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBeginDay = new DevExpress.XtraEditors.LabelControl();
            this.tabDetails = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.lblActiveCalendar = new DevExpress.XtraEditors.LabelControl();
            this.cmbActiveCalendar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmdCreateCalendar = new DevExpress.XtraEditors.SimpleButton();
            this.chkActivate = new DevExpress.XtraEditors.CheckEdit();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysXMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWorkweek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWorkday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartureTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBeginDay.Properties)).BeginInit();
            this.tabDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActiveCalendar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(12, 46);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.tabGeneral;
            this.TabControl.Size = new System.Drawing.Size(561, 200);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabDetails});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.spinDaysXMonth);
            this.tabGeneral.Controls.Add(this.lblDaysXMonth);
            this.tabGeneral.Controls.Add(this.spinWorkweek);
            this.tabGeneral.Controls.Add(this.lblWorkweek);
            this.tabGeneral.Controls.Add(this.spinWorkday);
            this.tabGeneral.Controls.Add(this.lblWorkday);
            this.tabGeneral.Controls.Add(this.txtDepartureTime);
            this.tabGeneral.Controls.Add(this.lblDepartureTime);
            this.tabGeneral.Controls.Add(this.txtCheck);
            this.tabGeneral.Controls.Add(this.lblCheck);
            this.tabGeneral.Controls.Add(this.cmbBeginDay);
            this.tabGeneral.Controls.Add(this.lblBeginDay);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(554, 172);
            this.tabGeneral.Text = "General";
            // 
            // spinDaysXMonth
            // 
            this.spinDaysXMonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDaysXMonth.Location = new System.Drawing.Point(403, 116);
            this.spinDaysXMonth.Name = "spinDaysXMonth";
            this.spinDaysXMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDaysXMonth.Size = new System.Drawing.Size(118, 20);
            this.spinDaysXMonth.TabIndex = 11;
            this.spinDaysXMonth.EditValueChanged += new System.EventHandler(this.spinDaysXMonth_EditValueChanged);
            // 
            // lblDaysXMonth
            // 
            this.lblDaysXMonth.Location = new System.Drawing.Point(286, 119);
            this.lblDaysXMonth.Name = "lblDaysXMonth";
            this.lblDaysXMonth.Size = new System.Drawing.Size(51, 13);
            this.lblDaysXMonth.TabIndex = 10;
            this.lblDaysXMonth.Text = "Dias X Mes";
            this.lblDaysXMonth.Click += new System.EventHandler(this.lblDaysXMonth_Click);
            // 
            // spinWorkweek
            // 
            this.spinWorkweek.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinWorkweek.Location = new System.Drawing.Point(403, 66);
            this.spinWorkweek.Name = "spinWorkweek";
            this.spinWorkweek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinWorkweek.Size = new System.Drawing.Size(118, 20);
            this.spinWorkweek.TabIndex = 9;
            this.spinWorkweek.EditValueChanged += new System.EventHandler(this.spinWorkweek_EditValueChanged);
            // 
            // lblWorkweek
            // 
            this.lblWorkweek.Location = new System.Drawing.Point(286, 69);
            this.lblWorkweek.Name = "lblWorkweek";
            this.lblWorkweek.Size = new System.Drawing.Size(76, 13);
            this.lblWorkweek.TabIndex = 8;
            this.lblWorkweek.Text = "Semana Laboral";
            this.lblWorkweek.Click += new System.EventHandler(this.lblWorkweek_Click);
            // 
            // spinWorkday
            // 
            this.spinWorkday.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinWorkday.Location = new System.Drawing.Point(403, 18);
            this.spinWorkday.Name = "spinWorkday";
            this.spinWorkday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinWorkday.Size = new System.Drawing.Size(118, 20);
            this.spinWorkday.TabIndex = 7;
            this.spinWorkday.EditValueChanged += new System.EventHandler(this.spinWorkday_EditValueChanged);
            // 
            // lblWorkday
            // 
            this.lblWorkday.Location = new System.Drawing.Point(286, 21);
            this.lblWorkday.Name = "lblWorkday";
            this.lblWorkday.Size = new System.Drawing.Size(77, 13);
            this.lblWorkday.TabIndex = 6;
            this.lblWorkday.Text = "Jornada Laboral";
            this.lblWorkday.Click += new System.EventHandler(this.lblWorkday_Click);
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(142, 116);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(118, 20);
            this.txtDepartureTime.TabIndex = 5;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Location = new System.Drawing.Point(25, 119);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(69, 13);
            this.lblDepartureTime.TabIndex = 4;
            this.lblDepartureTime.Text = "Hora de Salida";
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(142, 66);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(118, 20);
            this.txtCheck.TabIndex = 3;
            // 
            // lblCheck
            // 
            this.lblCheck.Location = new System.Drawing.Point(25, 69);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(79, 13);
            this.lblCheck.TabIndex = 2;
            this.lblCheck.Text = "Hora de Entrada";
            // 
            // cmbBeginDay
            // 
            this.cmbBeginDay.Location = new System.Drawing.Point(142, 18);
            this.cmbBeginDay.Name = "cmbBeginDay";
            this.cmbBeginDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBeginDay.Size = new System.Drawing.Size(118, 20);
            this.cmbBeginDay.TabIndex = 1;
            // 
            // lblBeginDay
            // 
            this.lblBeginDay.Location = new System.Drawing.Point(25, 21);
            this.lblBeginDay.Name = "lblBeginDay";
            this.lblBeginDay.Size = new System.Drawing.Size(105, 13);
            this.lblBeginDay.TabIndex = 0;
            this.lblBeginDay.Text = "La Semana Empieza el";
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.gridControl1);
            this.tabDetails.Controls.Add(this.dateNavigator1);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Size = new System.Drawing.Size(554, 172);
            this.tabDetails.Text = "Detalles";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(188, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(360, 169);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.DateTime = new System.DateTime(2011, 9, 8, 0, 0, 0, 0);
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(3, 1);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(179, 171);
            this.dateNavigator1.TabIndex = 5;
            // 
            // lblActiveCalendar
            // 
            this.lblActiveCalendar.Location = new System.Drawing.Point(14, 13);
            this.lblActiveCalendar.Name = "lblActiveCalendar";
            this.lblActiveCalendar.Size = new System.Drawing.Size(84, 13);
            this.lblActiveCalendar.TabIndex = 1;
            this.lblActiveCalendar.Text = "Calendario Activo";
            // 
            // cmbActiveCalendar
            // 
            this.cmbActiveCalendar.Location = new System.Drawing.Point(114, 10);
            this.cmbActiveCalendar.Name = "cmbActiveCalendar";
            this.cmbActiveCalendar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbActiveCalendar.Size = new System.Drawing.Size(131, 20);
            this.cmbActiveCalendar.TabIndex = 2;
            // 
            // cmdCreateCalendar
            // 
            this.cmdCreateCalendar.Location = new System.Drawing.Point(477, 13);
            this.cmdCreateCalendar.Name = "cmdCreateCalendar";
            this.cmdCreateCalendar.Size = new System.Drawing.Size(91, 23);
            this.cmdCreateCalendar.TabIndex = 3;
            this.cmdCreateCalendar.Text = "Crear Calendario";
            // 
            // chkActivate
            // 
            this.chkActivate.Location = new System.Drawing.Point(15, 261);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Properties.Caption = "Activar";
            this.chkActivate.Size = new System.Drawing.Size(75, 18);
            this.chkActivate.TabIndex = 4;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(493, 256);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(402, 256);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 6;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.chkActivate);
            this.Controls.Add(this.cmdCreateCalendar);
            this.Controls.Add(this.cmbActiveCalendar);
            this.Controls.Add(this.lblActiveCalendar);
            this.Controls.Add(this.TabControl);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysXMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWorkweek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWorkday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartureTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBeginDay.Properties)).EndInit();
            this.tabDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActiveCalendar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage tabGeneral;
        private DevExpress.XtraTab.XtraTabPage tabDetails;
        private DevExpress.XtraEditors.SpinEdit spinDaysXMonth;
        private DevExpress.XtraEditors.LabelControl lblDaysXMonth;
        private DevExpress.XtraEditors.SpinEdit spinWorkweek;
        private DevExpress.XtraEditors.LabelControl lblWorkweek;
        private DevExpress.XtraEditors.SpinEdit spinWorkday;
        private DevExpress.XtraEditors.LabelControl lblWorkday;
        private DevExpress.XtraEditors.TextEdit txtDepartureTime;
        private DevExpress.XtraEditors.LabelControl lblDepartureTime;
        private DevExpress.XtraEditors.TextEdit txtCheck;
        private DevExpress.XtraEditors.LabelControl lblCheck;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBeginDay;
        private DevExpress.XtraEditors.LabelControl lblBeginDay;
        private DevExpress.XtraEditors.LabelControl lblActiveCalendar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbActiveCalendar;
        private DevExpress.XtraEditors.SimpleButton cmdCreateCalendar;
        private DevExpress.XtraEditors.CheckEdit chkActivate;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
    }
}