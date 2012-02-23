namespace shellProject
{
    partial class CreateProject
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
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.spinCode = new DevExpress.XtraEditors.SpinEdit();
            this.chkCxcApproval = new DevExpress.XtraEditors.CheckEdit();
            this.chkManagementApproval = new DevExpress.XtraEditors.CheckEdit();
            this.txtSalesConsultant = new DevExpress.XtraEditors.TextEdit();
            this.txtCustumer = new DevExpress.XtraEditors.TextEdit();
            this.txtProject = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblSalesConsultant = new DevExpress.XtraEditors.LabelControl();
            this.lblClient = new DevExpress.XtraEditors.LabelControl();
            this.lblProject = new DevExpress.XtraEditors.LabelControl();
            this.tabTotals = new DevExpress.XtraTab.XtraTabPage();
            this.spinOtherAmount = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiscountAmount = new DevExpress.XtraEditors.SpinEdit();
            this.spinSubTotal = new DevExpress.XtraEditors.SpinEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.spinOthersRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinSalesTax = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiscountRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinTotalUtilityRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinGuaranteeRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinContingenciesRate = new DevExpress.XtraEditors.SpinEdit();
            this.lblOtherAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblOthersRate = new DevExpress.XtraEditors.LabelControl();
            this.lblSalesTax = new DevExpress.XtraEditors.LabelControl();
            this.lblDiscountAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblDiscountRate = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalUtilityRate = new DevExpress.XtraEditors.LabelControl();
            this.lblGuaranteeRate = new DevExpress.XtraEditors.LabelControl();
            this.lblContingenciesRate = new DevExpress.XtraEditors.LabelControl();
            this.tabComments = new DevExpress.XtraTab.XtraTabPage();
            this.memoComments = new DevExpress.XtraEditors.MemoEdit();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuoteNumber = new System.Windows.Forms.Label();
            this.txtQuoteNumber = new DevExpress.XtraEditors.ButtonEdit();
            this.dtCreateDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesConsultant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustumer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProject.Properties)).BeginInit();
            this.tabTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOtherAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalesTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalUtilityRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGuaranteeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinContingenciesRate.Properties)).BeginInit();
            this.tabComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuoteNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(7, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabGeneral;
            this.tabControl.Size = new System.Drawing.Size(421, 212);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabTotals,
            this.tabComments});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.spinCode);
            this.tabGeneral.Controls.Add(this.chkCxcApproval);
            this.tabGeneral.Controls.Add(this.chkManagementApproval);
            this.tabGeneral.Controls.Add(this.txtSalesConsultant);
            this.tabGeneral.Controls.Add(this.txtCustumer);
            this.tabGeneral.Controls.Add(this.txtProject);
            this.tabGeneral.Controls.Add(this.lblCode);
            this.tabGeneral.Controls.Add(this.lblSalesConsultant);
            this.tabGeneral.Controls.Add(this.lblClient);
            this.tabGeneral.Controls.Add(this.lblProject);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(414, 184);
            this.tabGeneral.Text = "General";
            // 
            // spinCode
            // 
            this.spinCode.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCode.Location = new System.Drawing.Point(90, 8);
            this.spinCode.Name = "spinCode";
            this.spinCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCode.Size = new System.Drawing.Size(126, 20);
            this.spinCode.TabIndex = 10;
            // 
            // chkCxcApproval
            // 
            this.chkCxcApproval.Enabled = false;
            this.chkCxcApproval.Location = new System.Drawing.Point(13, 150);
            this.chkCxcApproval.Name = "chkCxcApproval";
            this.chkCxcApproval.Properties.Caption = "Aprobación CxC";
            this.chkCxcApproval.Properties.ReadOnly = true;
            this.chkCxcApproval.Size = new System.Drawing.Size(177, 18);
            this.chkCxcApproval.TabIndex = 9;
            // 
            // chkManagementApproval
            // 
            this.chkManagementApproval.Enabled = false;
            this.chkManagementApproval.Location = new System.Drawing.Point(13, 126);
            this.chkManagementApproval.Name = "chkManagementApproval";
            this.chkManagementApproval.Properties.Caption = "Aprobación Gerencia";
            this.chkManagementApproval.Properties.ReadOnly = true;
            this.chkManagementApproval.Size = new System.Drawing.Size(177, 18);
            this.chkManagementApproval.TabIndex = 8;
            // 
            // txtSalesConsultant
            // 
            this.txtSalesConsultant.Location = new System.Drawing.Point(90, 94);
            this.txtSalesConsultant.Name = "txtSalesConsultant";
            this.txtSalesConsultant.Size = new System.Drawing.Size(303, 20);
            this.txtSalesConsultant.TabIndex = 7;
            // 
            // txtCustumer
            // 
            this.txtCustumer.Location = new System.Drawing.Point(90, 66);
            this.txtCustumer.Name = "txtCustumer";
            this.txtCustumer.Size = new System.Drawing.Size(303, 20);
            this.txtCustumer.TabIndex = 5;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(90, 36);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(303, 20);
            this.txtProject.TabIndex = 4;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(15, 11);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(33, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Código";
            // 
            // lblSalesConsultant
            // 
            this.lblSalesConsultant.Location = new System.Drawing.Point(15, 97);
            this.lblSalesConsultant.Name = "lblSalesConsultant";
            this.lblSalesConsultant.Size = new System.Drawing.Size(46, 13);
            this.lblSalesConsultant.TabIndex = 2;
            this.lblSalesConsultant.Text = "Vendedor";
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(15, 69);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Cliente";
            // 
            // lblProject
            // 
            this.lblProject.Location = new System.Drawing.Point(15, 39);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Proyecto";
            // 
            // tabTotals
            // 
            this.tabTotals.Controls.Add(this.spinOtherAmount);
            this.tabTotals.Controls.Add(this.spinDiscountAmount);
            this.tabTotals.Controls.Add(this.spinSubTotal);
            this.tabTotals.Controls.Add(this.txtTotal);
            this.tabTotals.Controls.Add(this.lblTotal);
            this.tabTotals.Controls.Add(this.spinOthersRate);
            this.tabTotals.Controls.Add(this.spinSalesTax);
            this.tabTotals.Controls.Add(this.spinDiscountRate);
            this.tabTotals.Controls.Add(this.spinTotalUtilityRate);
            this.tabTotals.Controls.Add(this.spinGuaranteeRate);
            this.tabTotals.Controls.Add(this.spinContingenciesRate);
            this.tabTotals.Controls.Add(this.lblOtherAmount);
            this.tabTotals.Controls.Add(this.lblOthersRate);
            this.tabTotals.Controls.Add(this.lblSalesTax);
            this.tabTotals.Controls.Add(this.lblDiscountAmount);
            this.tabTotals.Controls.Add(this.lblDiscountRate);
            this.tabTotals.Controls.Add(this.lblSubtotal);
            this.tabTotals.Controls.Add(this.lblTotalUtilityRate);
            this.tabTotals.Controls.Add(this.lblGuaranteeRate);
            this.tabTotals.Controls.Add(this.lblContingenciesRate);
            this.tabTotals.Name = "tabTotals";
            this.tabTotals.Size = new System.Drawing.Size(414, 184);
            this.tabTotals.Text = "Totales";
            // 
            // spinOtherAmount
            // 
            this.spinOtherAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinOtherAmount.Location = new System.Drawing.Point(307, 72);
            this.spinOtherAmount.Name = "spinOtherAmount";
            this.spinOtherAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinOtherAmount.Properties.ReadOnly = true;
            this.spinOtherAmount.Size = new System.Drawing.Size(100, 20);
            this.spinOtherAmount.TabIndex = 22;
            // 
            // spinDiscountAmount
            // 
            this.spinDiscountAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscountAmount.Location = new System.Drawing.Point(98, 154);
            this.spinDiscountAmount.Name = "spinDiscountAmount";
            this.spinDiscountAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscountAmount.Properties.ReadOnly = true;
            this.spinDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.spinDiscountAmount.TabIndex = 21;
            // 
            // spinSubTotal
            // 
            this.spinSubTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotal.Location = new System.Drawing.Point(98, 97);
            this.spinSubTotal.Name = "spinSubTotal";
            this.spinSubTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotal.Properties.ReadOnly = true;
            this.spinSubTotal.Size = new System.Drawing.Size(100, 20);
            this.spinSubTotal.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(235, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Size = new System.Drawing.Size(172, 29);
            this.txtTotal.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(307, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // spinOthersRate
            // 
            this.spinOthersRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinOthersRate.Location = new System.Drawing.Point(307, 41);
            this.spinOthersRate.Name = "spinOthersRate";
            this.spinOthersRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinOthersRate.Size = new System.Drawing.Size(100, 20);
            this.spinOthersRate.TabIndex = 16;
            // 
            // spinSalesTax
            // 
            this.spinSalesTax.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSalesTax.Location = new System.Drawing.Point(307, 10);
            this.spinSalesTax.Name = "spinSalesTax";
            this.spinSalesTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSalesTax.Size = new System.Drawing.Size(100, 20);
            this.spinSalesTax.TabIndex = 15;
            // 
            // spinDiscountRate
            // 
            this.spinDiscountRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscountRate.Location = new System.Drawing.Point(98, 125);
            this.spinDiscountRate.Name = "spinDiscountRate";
            this.spinDiscountRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscountRate.Size = new System.Drawing.Size(100, 20);
            this.spinDiscountRate.TabIndex = 13;
            // 
            // spinTotalUtilityRate
            // 
            this.spinTotalUtilityRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalUtilityRate.Location = new System.Drawing.Point(98, 68);
            this.spinTotalUtilityRate.Name = "spinTotalUtilityRate";
            this.spinTotalUtilityRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalUtilityRate.Size = new System.Drawing.Size(100, 20);
            this.spinTotalUtilityRate.TabIndex = 11;
            // 
            // spinGuaranteeRate
            // 
            this.spinGuaranteeRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGuaranteeRate.Location = new System.Drawing.Point(98, 41);
            this.spinGuaranteeRate.Name = "spinGuaranteeRate";
            this.spinGuaranteeRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinGuaranteeRate.Size = new System.Drawing.Size(100, 20);
            this.spinGuaranteeRate.TabIndex = 10;
            // 
            // spinContingenciesRate
            // 
            this.spinContingenciesRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinContingenciesRate.Location = new System.Drawing.Point(98, 13);
            this.spinContingenciesRate.Name = "spinContingenciesRate";
            this.spinContingenciesRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinContingenciesRate.Size = new System.Drawing.Size(100, 20);
            this.spinContingenciesRate.TabIndex = 9;
            // 
            // lblOtherAmount
            // 
            this.lblOtherAmount.Location = new System.Drawing.Point(235, 75);
            this.lblOtherAmount.Name = "lblOtherAmount";
            this.lblOtherAmount.Size = new System.Drawing.Size(60, 13);
            this.lblOtherAmount.TabIndex = 8;
            this.lblOtherAmount.Text = "Monto Otros";
            // 
            // lblOthersRate
            // 
            this.lblOthersRate.Location = new System.Drawing.Point(235, 41);
            this.lblOthersRate.Name = "lblOthersRate";
            this.lblOthersRate.Size = new System.Drawing.Size(41, 13);
            this.lblOthersRate.TabIndex = 7;
            this.lblOthersRate.Text = "% Otros";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.Location = new System.Drawing.Point(235, 13);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(14, 13);
            this.lblSalesTax.TabIndex = 6;
            this.lblSalesTax.Text = "I.V";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Location = new System.Drawing.Point(7, 155);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(84, 13);
            this.lblDiscountAmount.TabIndex = 5;
            this.lblDiscountAmount.Text = "Monto Descuento";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.Location = new System.Drawing.Point(7, 128);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(60, 13);
            this.lblDiscountRate.TabIndex = 4;
            this.lblDiscountRate.Text = "% Desuento";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(7, 101);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(40, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTotalUtilityRate
            // 
            this.lblTotalUtilityRate.Location = new System.Drawing.Point(7, 71);
            this.lblTotalUtilityRate.Name = "lblTotalUtilityRate";
            this.lblTotalUtilityRate.Size = new System.Drawing.Size(62, 13);
            this.lblTotalUtilityRate.TabIndex = 2;
            this.lblTotalUtilityRate.Text = "Utilidad Total";
            // 
            // lblGuaranteeRate
            // 
            this.lblGuaranteeRate.Location = new System.Drawing.Point(7, 41);
            this.lblGuaranteeRate.Name = "lblGuaranteeRate";
            this.lblGuaranteeRate.Size = new System.Drawing.Size(41, 13);
            this.lblGuaranteeRate.TabIndex = 1;
            this.lblGuaranteeRate.Text = "Garantia";
            // 
            // lblContingenciesRate
            // 
            this.lblContingenciesRate.Location = new System.Drawing.Point(7, 13);
            this.lblContingenciesRate.Name = "lblContingenciesRate";
            this.lblContingenciesRate.Size = new System.Drawing.Size(56, 13);
            this.lblContingenciesRate.TabIndex = 0;
            this.lblContingenciesRate.Text = "Imprevistos";
            // 
            // tabComments
            // 
            this.tabComments.Controls.Add(this.memoComments);
            this.tabComments.Name = "tabComments";
            this.tabComments.Size = new System.Drawing.Size(414, 184);
            this.tabComments.Text = "Comentarios";
            // 
            // memoComments
            // 
            this.memoComments.Location = new System.Drawing.Point(7, 12);
            this.memoComments.Name = "memoComments";
            this.memoComments.Size = new System.Drawing.Size(394, 158);
            this.memoComments.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(349, 253);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Salir";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(247, 253);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Aceptar";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblQuoteNumber
            // 
            this.lblQuoteNumber.AutoSize = true;
            this.lblQuoteNumber.Location = new System.Drawing.Point(6, 9);
            this.lblQuoteNumber.Name = "lblQuoteNumber";
            this.lblQuoteNumber.Size = new System.Drawing.Size(72, 13);
            this.lblQuoteNumber.TabIndex = 5;
            this.lblQuoteNumber.Text = "# de Solicitud";
            // 
            // txtQuoteNumber
            // 
            this.txtQuoteNumber.Location = new System.Drawing.Point(94, 6);
            this.txtQuoteNumber.Name = "txtQuoteNumber";
            this.txtQuoteNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtQuoteNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtQuoteNumber.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtQuoteNumber_Properties_ButtonClick);
            this.txtQuoteNumber.Size = new System.Drawing.Size(131, 20);
            this.txtQuoteNumber.TabIndex = 6;
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.EditValue = new System.DateTime(2011, 9, 7, 8, 57, 9, 0);
            this.dtCreateDate.Location = new System.Drawing.Point(337, 6);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCreateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtCreateDate.Size = new System.Drawing.Size(80, 20);
            this.dtCreateDate.TabIndex = 7;
            // 
            // CreateProject
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.dtCreateDate);
            this.Controls.Add(this.txtQuoteNumber);
            this.Controls.Add(this.lblQuoteNumber);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información del Proyecto";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesConsultant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustumer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProject.Properties)).EndInit();
            this.tabTotals.ResumeLayout(false);
            this.tabTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOtherAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalesTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalUtilityRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGuaranteeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinContingenciesRate.Properties)).EndInit();
            this.tabComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuoteNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabGeneral;
        private DevExpress.XtraEditors.TextEdit txtSalesConsultant;
        private DevExpress.XtraEditors.TextEdit txtCustumer;
        private DevExpress.XtraEditors.TextEdit txtProject;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblSalesConsultant;
        private DevExpress.XtraEditors.LabelControl lblClient;
        private DevExpress.XtraEditors.LabelControl lblProject;
        private DevExpress.XtraTab.XtraTabPage tabTotals;
        private DevExpress.XtraTab.XtraTabPage tabComments;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private System.Windows.Forms.Label lblQuoteNumber;
        private DevExpress.XtraEditors.ButtonEdit txtQuoteNumber;
        private DevExpress.XtraEditors.DateEdit dtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.SpinEdit spinOthersRate;
        private DevExpress.XtraEditors.SpinEdit spinSalesTax;
        private DevExpress.XtraEditors.SpinEdit spinDiscountRate;
        private DevExpress.XtraEditors.SpinEdit spinTotalUtilityRate;
        private DevExpress.XtraEditors.SpinEdit spinGuaranteeRate;
        private DevExpress.XtraEditors.SpinEdit spinContingenciesRate;
        private DevExpress.XtraEditors.LabelControl lblOtherAmount;
        private DevExpress.XtraEditors.LabelControl lblOthersRate;
        private DevExpress.XtraEditors.LabelControl lblSalesTax;
        private DevExpress.XtraEditors.LabelControl lblDiscountAmount;
        private DevExpress.XtraEditors.LabelControl lblDiscountRate;
        private DevExpress.XtraEditors.LabelControl lblSubtotal;
        private DevExpress.XtraEditors.LabelControl lblTotalUtilityRate;
        private DevExpress.XtraEditors.LabelControl lblGuaranteeRate;
        private DevExpress.XtraEditors.LabelControl lblContingenciesRate;
        private DevExpress.XtraEditors.MemoEdit memoComments;
        private DevExpress.XtraEditors.CheckEdit chkCxcApproval;
        private DevExpress.XtraEditors.CheckEdit chkManagementApproval;
        private DevExpress.XtraEditors.SpinEdit spinCode;
        private DevExpress.XtraEditors.SpinEdit spinSubTotal;
        private DevExpress.XtraEditors.SpinEdit spinOtherAmount;
        private DevExpress.XtraEditors.SpinEdit spinDiscountAmount;
    }
}