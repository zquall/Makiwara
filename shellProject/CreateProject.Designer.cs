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
            this.txtFamily = new DevExpress.XtraEditors.ButtonEdit();
            this.lblFamily = new DevExpress.XtraEditors.LabelControl();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
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
            this.spinTotalMeters = new DevExpress.XtraEditors.SpinEdit();
            this.lblTotalMeters = new DevExpress.XtraEditors.LabelControl();
            this.spinTotal = new DevExpress.XtraEditors.SpinEdit();
            this.spinSubTotalC = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiscountAmount = new DevExpress.XtraEditors.SpinEdit();
            this.spinSubTotal = new DevExpress.XtraEditors.SpinEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.spinOthersRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinSubTotalB = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiscountRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinTotalUtilityRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinGuaranteeRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinContingenciesRate = new DevExpress.XtraEditors.SpinEdit();
            this.lblSubtotalC = new DevExpress.XtraEditors.LabelControl();
            this.lblOthersRate = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotalB = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesConsultant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustumer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProject.Properties)).BeginInit();
            this.tabTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalMeters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotalC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotalB.Properties)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(421, 248);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabTotals,
            this.tabComments});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.txtFamily);
            this.tabGeneral.Controls.Add(this.lblFamily);
            this.tabGeneral.Controls.Add(this.txtState);
            this.tabGeneral.Controls.Add(this.txtCode);
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
            this.tabGeneral.Size = new System.Drawing.Size(414, 220);
            this.tabGeneral.Text = "General";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(90, 124);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFamily.Properties.ReadOnly = true;
            this.txtFamily.Size = new System.Drawing.Size(303, 20);
            this.txtFamily.TabIndex = 14;
            // 
            // lblFamily
            // 
            this.lblFamily.Location = new System.Drawing.Point(15, 127);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(32, 13);
            this.lblFamily.TabIndex = 13;
            this.lblFamily.Text = "Familia";
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtState.Location = new System.Drawing.Point(238, 157);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(155, 40);
            this.txtState.TabIndex = 12;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(90, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(126, 20);
            this.txtCode.TabIndex = 11;
            // 
            // chkCxcApproval
            // 
            this.chkCxcApproval.Enabled = false;
            this.chkCxcApproval.Location = new System.Drawing.Point(13, 179);
            this.chkCxcApproval.Name = "chkCxcApproval";
            this.chkCxcApproval.Properties.Caption = "Aprobación CxC";
            this.chkCxcApproval.Properties.ReadOnly = true;
            this.chkCxcApproval.Size = new System.Drawing.Size(177, 18);
            this.chkCxcApproval.TabIndex = 9;
            // 
            // chkManagementApproval
            // 
            this.chkManagementApproval.Enabled = false;
            this.chkManagementApproval.Location = new System.Drawing.Point(13, 155);
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
            this.tabTotals.Controls.Add(this.spinTotalMeters);
            this.tabTotals.Controls.Add(this.lblTotalMeters);
            this.tabTotals.Controls.Add(this.spinTotal);
            this.tabTotals.Controls.Add(this.spinSubTotalC);
            this.tabTotals.Controls.Add(this.spinDiscountAmount);
            this.tabTotals.Controls.Add(this.spinSubTotal);
            this.tabTotals.Controls.Add(this.lblTotal);
            this.tabTotals.Controls.Add(this.spinOthersRate);
            this.tabTotals.Controls.Add(this.spinSubTotalB);
            this.tabTotals.Controls.Add(this.spinDiscountRate);
            this.tabTotals.Controls.Add(this.spinTotalUtilityRate);
            this.tabTotals.Controls.Add(this.spinGuaranteeRate);
            this.tabTotals.Controls.Add(this.spinContingenciesRate);
            this.tabTotals.Controls.Add(this.lblSubtotalC);
            this.tabTotals.Controls.Add(this.lblOthersRate);
            this.tabTotals.Controls.Add(this.lblSubTotalB);
            this.tabTotals.Controls.Add(this.lblDiscountAmount);
            this.tabTotals.Controls.Add(this.lblDiscountRate);
            this.tabTotals.Controls.Add(this.lblSubtotal);
            this.tabTotals.Controls.Add(this.lblTotalUtilityRate);
            this.tabTotals.Controls.Add(this.lblGuaranteeRate);
            this.tabTotals.Controls.Add(this.lblContingenciesRate);
            this.tabTotals.Name = "tabTotals";
            this.tabTotals.Size = new System.Drawing.Size(414, 220);
            this.tabTotals.Text = "Totales";
            // 
            // spinTotalMeters
            // 
            this.spinTotalMeters.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalMeters.Location = new System.Drawing.Point(303, 130);
            this.spinTotalMeters.Name = "spinTotalMeters";
            this.spinTotalMeters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalMeters.Size = new System.Drawing.Size(100, 20);
            this.spinTotalMeters.TabIndex = 25;
            // 
            // lblTotalMeters
            // 
            this.lblTotalMeters.Location = new System.Drawing.Point(208, 133);
            this.lblTotalMeters.Name = "lblTotalMeters";
            this.lblTotalMeters.Size = new System.Drawing.Size(71, 13);
            this.lblTotalMeters.TabIndex = 24;
            this.lblTotalMeters.Text = "Metros Totales";
            // 
            // spinTotal
            // 
            this.spinTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotal.Location = new System.Drawing.Point(115, 179);
            this.spinTotal.Name = "spinTotal";
            this.spinTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.spinTotal.Properties.Appearance.Options.UseFont = true;
            this.spinTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotal.Properties.Mask.EditMask = "c";
            this.spinTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinTotal.Properties.ReadOnly = true;
            this.spinTotal.Size = new System.Drawing.Size(212, 31);
            this.spinTotal.TabIndex = 23;
            // 
            // spinSubTotalC
            // 
            this.spinSubTotalC.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotalC.Location = new System.Drawing.Point(303, 38);
            this.spinSubTotalC.Name = "spinSubTotalC";
            this.spinSubTotalC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotalC.Properties.Mask.EditMask = "c";
            this.spinSubTotalC.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinSubTotalC.Properties.ReadOnly = true;
            this.spinSubTotalC.Size = new System.Drawing.Size(100, 20);
            this.spinSubTotalC.TabIndex = 22;
            // 
            // spinDiscountAmount
            // 
            this.spinDiscountAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscountAmount.Location = new System.Drawing.Point(303, 99);
            this.spinDiscountAmount.Name = "spinDiscountAmount";
            this.spinDiscountAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscountAmount.Properties.Mask.EditMask = "c";
            this.spinDiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
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
            this.spinSubTotal.Location = new System.Drawing.Point(83, 9);
            this.spinSubTotal.Name = "spinSubTotal";
            this.spinSubTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotal.Properties.Mask.EditMask = "c";
            this.spinSubTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinSubTotal.Properties.ReadOnly = true;
            this.spinSubTotal.Size = new System.Drawing.Size(100, 20);
            this.spinSubTotal.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(206, 160);
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
            this.spinOthersRate.Location = new System.Drawing.Point(82, 99);
            this.spinOthersRate.Name = "spinOthersRate";
            this.spinOthersRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinOthersRate.Properties.Mask.EditMask = "f";
            this.spinOthersRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinOthersRate.Size = new System.Drawing.Size(100, 20);
            this.spinOthersRate.TabIndex = 16;
            this.spinOthersRate.EditValueChanged += new System.EventHandler(this.SpinOthersRateEditValueChanged);
            // 
            // spinSubTotalB
            // 
            this.spinSubTotalB.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSubTotalB.Location = new System.Drawing.Point(82, 130);
            this.spinSubTotalB.Name = "spinSubTotalB";
            this.spinSubTotalB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinSubTotalB.Properties.Mask.EditMask = "c";
            this.spinSubTotalB.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinSubTotalB.Properties.ReadOnly = true;
            this.spinSubTotalB.Size = new System.Drawing.Size(100, 20);
            this.spinSubTotalB.TabIndex = 15;
            // 
            // spinDiscountRate
            // 
            this.spinDiscountRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscountRate.Location = new System.Drawing.Point(303, 69);
            this.spinDiscountRate.Name = "spinDiscountRate";
            this.spinDiscountRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscountRate.Properties.Mask.EditMask = "f";
            this.spinDiscountRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinDiscountRate.Size = new System.Drawing.Size(100, 20);
            this.spinDiscountRate.TabIndex = 13;
            this.spinDiscountRate.EditValueChanged += new System.EventHandler(this.SpinDiscountRateEditValueChanged);
            // 
            // spinTotalUtilityRate
            // 
            this.spinTotalUtilityRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalUtilityRate.Location = new System.Drawing.Point(303, 10);
            this.spinTotalUtilityRate.Name = "spinTotalUtilityRate";
            this.spinTotalUtilityRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalUtilityRate.Properties.Mask.EditMask = "f";
            this.spinTotalUtilityRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinTotalUtilityRate.Size = new System.Drawing.Size(100, 20);
            this.spinTotalUtilityRate.TabIndex = 11;
            this.spinTotalUtilityRate.EditValueChanged += new System.EventHandler(this.SpinTotalUtilityRateEditValueChanged);
            // 
            // spinGuaranteeRate
            // 
            this.spinGuaranteeRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGuaranteeRate.Location = new System.Drawing.Point(82, 69);
            this.spinGuaranteeRate.Name = "spinGuaranteeRate";
            this.spinGuaranteeRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinGuaranteeRate.Properties.Mask.EditMask = "f";
            this.spinGuaranteeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinGuaranteeRate.Size = new System.Drawing.Size(100, 20);
            this.spinGuaranteeRate.TabIndex = 10;
            this.spinGuaranteeRate.EditValueChanged += new System.EventHandler(this.SpinGuaranteeRateEditValueChanged);
            // 
            // spinContingenciesRate
            // 
            this.spinContingenciesRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinContingenciesRate.Location = new System.Drawing.Point(82, 41);
            this.spinContingenciesRate.Name = "spinContingenciesRate";
            this.spinContingenciesRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinContingenciesRate.Properties.Mask.EditMask = "f";
            this.spinContingenciesRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinContingenciesRate.Size = new System.Drawing.Size(100, 20);
            this.spinContingenciesRate.TabIndex = 9;
            this.spinContingenciesRate.EditValueChanged += new System.EventHandler(this.SpinContingenciesRateEditValueChanged);
            // 
            // lblSubtotalC
            // 
            this.lblSubtotalC.Location = new System.Drawing.Point(212, 41);
            this.lblSubtotalC.Name = "lblSubtotalC";
            this.lblSubtotalC.Size = new System.Drawing.Size(50, 13);
            this.lblSubtotalC.TabIndex = 8;
            this.lblSubtotalC.Text = "Subtotal C";
            // 
            // lblOthersRate
            // 
            this.lblOthersRate.Location = new System.Drawing.Point(8, 101);
            this.lblOthersRate.Name = "lblOthersRate";
            this.lblOthersRate.Size = new System.Drawing.Size(41, 13);
            this.lblOthersRate.TabIndex = 7;
            this.lblOthersRate.Text = "% Otros";
            // 
            // lblSubTotalB
            // 
            this.lblSubTotalB.Location = new System.Drawing.Point(8, 133);
            this.lblSubTotalB.Name = "lblSubTotalB";
            this.lblSubTotalB.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotalB.TabIndex = 6;
            this.lblSubTotalB.Text = "Subtotal B";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Location = new System.Drawing.Point(208, 101);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(84, 13);
            this.lblDiscountAmount.TabIndex = 5;
            this.lblDiscountAmount.Text = "Monto Descuento";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.Location = new System.Drawing.Point(208, 72);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(60, 13);
            this.lblDiscountRate.TabIndex = 4;
            this.lblDiscountRate.Text = "% Desuento";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(8, 13);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(40, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTotalUtilityRate
            // 
            this.lblTotalUtilityRate.Location = new System.Drawing.Point(212, 13);
            this.lblTotalUtilityRate.Name = "lblTotalUtilityRate";
            this.lblTotalUtilityRate.Size = new System.Drawing.Size(62, 13);
            this.lblTotalUtilityRate.TabIndex = 2;
            this.lblTotalUtilityRate.Text = "Utilidad Total";
            // 
            // lblGuaranteeRate
            // 
            this.lblGuaranteeRate.Location = new System.Drawing.Point(7, 69);
            this.lblGuaranteeRate.Name = "lblGuaranteeRate";
            this.lblGuaranteeRate.Size = new System.Drawing.Size(41, 13);
            this.lblGuaranteeRate.TabIndex = 1;
            this.lblGuaranteeRate.Text = "Garantia";
            // 
            // lblContingenciesRate
            // 
            this.lblContingenciesRate.Location = new System.Drawing.Point(7, 41);
            this.lblContingenciesRate.Name = "lblContingenciesRate";
            this.lblContingenciesRate.Size = new System.Drawing.Size(56, 13);
            this.lblContingenciesRate.TabIndex = 0;
            this.lblContingenciesRate.Text = "Imprevistos";
            // 
            // tabComments
            // 
            this.tabComments.Controls.Add(this.memoComments);
            this.tabComments.Name = "tabComments";
            this.tabComments.Size = new System.Drawing.Size(414, 220);
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
            this.cmdCancel.Location = new System.Drawing.Point(348, 286);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Salir";
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancelClick);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(246, 286);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Aceptar";
            this.cmdSave.Click += new System.EventHandler(this.CmdSaveClick);
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
            this.txtQuoteNumber.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtQuoteNumberPropertiesButtonClick);
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
            this.ClientSize = new System.Drawing.Size(434, 321);
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
            this.Load += new System.EventHandler(this.CreateProjectLoad);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesConsultant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustumer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProject.Properties)).EndInit();
            this.tabTotals.ResumeLayout(false);
            this.tabTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalMeters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotalC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSubTotalB.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.SpinEdit spinOthersRate;
        private DevExpress.XtraEditors.SpinEdit spinSubTotalB;
        private DevExpress.XtraEditors.SpinEdit spinDiscountRate;
        private DevExpress.XtraEditors.SpinEdit spinTotalUtilityRate;
        private DevExpress.XtraEditors.SpinEdit spinGuaranteeRate;
        private DevExpress.XtraEditors.SpinEdit spinContingenciesRate;
        private DevExpress.XtraEditors.LabelControl lblSubtotalC;
        private DevExpress.XtraEditors.LabelControl lblOthersRate;
        private DevExpress.XtraEditors.LabelControl lblSubTotalB;
        private DevExpress.XtraEditors.LabelControl lblDiscountAmount;
        private DevExpress.XtraEditors.LabelControl lblDiscountRate;
        private DevExpress.XtraEditors.LabelControl lblSubtotal;
        private DevExpress.XtraEditors.LabelControl lblTotalUtilityRate;
        private DevExpress.XtraEditors.LabelControl lblGuaranteeRate;
        private DevExpress.XtraEditors.LabelControl lblContingenciesRate;
        private DevExpress.XtraEditors.MemoEdit memoComments;
        private DevExpress.XtraEditors.CheckEdit chkCxcApproval;
        private DevExpress.XtraEditors.CheckEdit chkManagementApproval;
        private DevExpress.XtraEditors.SpinEdit spinSubTotal;
        private DevExpress.XtraEditors.SpinEdit spinSubTotalC;
        private DevExpress.XtraEditors.SpinEdit spinDiscountAmount;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.TextBox txtState;
        private DevExpress.XtraEditors.ButtonEdit txtFamily;
        private DevExpress.XtraEditors.LabelControl lblFamily;
        private DevExpress.XtraEditors.SpinEdit spinTotal;
        private DevExpress.XtraEditors.SpinEdit spinTotalMeters;
        private DevExpress.XtraEditors.LabelControl lblTotalMeters;
    }
}