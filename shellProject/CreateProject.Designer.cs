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
            this.chkCxcApproval = new DevExpress.XtraEditors.CheckEdit();
            this.chkManagementApproval = new DevExpress.XtraEditors.CheckEdit();
            this.txtSeller = new DevExpress.XtraEditors.TextEdit();
            this.txtFamily = new DevExpress.XtraEditors.TextEdit();
            this.txtClient = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblFamily = new DevExpress.XtraEditors.LabelControl();
            this.lblSeller = new DevExpress.XtraEditors.LabelControl();
            this.lblClient = new DevExpress.XtraEditors.LabelControl();
            this.lblProject = new DevExpress.XtraEditors.LabelControl();
            this.tabTotals = new DevExpress.XtraTab.XtraTabPage();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.textOtherAmount = new DevExpress.XtraEditors.TextEdit();
            this.spinOthersRate = new DevExpress.XtraEditors.SpinEdit();
            this.spinSalesTax = new DevExpress.XtraEditors.SpinEdit();
            this.txtDiscountAmount = new DevExpress.XtraEditors.TextEdit();
            this.spinDiscountRate = new DevExpress.XtraEditors.SpinEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeller.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.tabTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOtherAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalesTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(3, 32);
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
            this.tabGeneral.Controls.Add(this.chkCxcApproval);
            this.tabGeneral.Controls.Add(this.chkManagementApproval);
            this.tabGeneral.Controls.Add(this.txtSeller);
            this.tabGeneral.Controls.Add(this.txtFamily);
            this.tabGeneral.Controls.Add(this.txtClient);
            this.tabGeneral.Controls.Add(this.textEdit1);
            this.tabGeneral.Controls.Add(this.lblFamily);
            this.tabGeneral.Controls.Add(this.lblSeller);
            this.tabGeneral.Controls.Add(this.lblClient);
            this.tabGeneral.Controls.Add(this.lblProject);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(414, 184);
            this.tabGeneral.Text = "General";
            // 
            // chkCxcApproval
            // 
            this.chkCxcApproval.Location = new System.Drawing.Point(13, 150);
            this.chkCxcApproval.Name = "chkCxcApproval";
            this.chkCxcApproval.Properties.Caption = "Aprobación CxC";
            this.chkCxcApproval.Size = new System.Drawing.Size(177, 18);
            this.chkCxcApproval.TabIndex = 9;
            // 
            // chkManagementApproval
            // 
            this.chkManagementApproval.Location = new System.Drawing.Point(13, 126);
            this.chkManagementApproval.Name = "chkManagementApproval";
            this.chkManagementApproval.Properties.Caption = "Aprobación Gerencia";
            this.chkManagementApproval.Size = new System.Drawing.Size(177, 18);
            this.chkManagementApproval.TabIndex = 8;
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(90, 70);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(303, 20);
            this.txtSeller.TabIndex = 7;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(90, 100);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFamily.TabIndex = 6;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(90, 42);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(303, 20);
            this.txtClient.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(90, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(303, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // lblFamily
            // 
            this.lblFamily.Location = new System.Drawing.Point(15, 103);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(32, 13);
            this.lblFamily.TabIndex = 3;
            this.lblFamily.Text = "Familia";
            // 
            // lblSeller
            // 
            this.lblSeller.Location = new System.Drawing.Point(15, 73);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(46, 13);
            this.lblSeller.TabIndex = 2;
            this.lblSeller.Text = "Vendedor";
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(15, 45);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Cliente";
            // 
            // lblProject
            // 
            this.lblProject.Location = new System.Drawing.Point(15, 15);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Proyecto";
            // 
            // tabTotals
            // 
            this.tabTotals.Controls.Add(this.txtTotal);
            this.tabTotals.Controls.Add(this.lblTotal);
            this.tabTotals.Controls.Add(this.textOtherAmount);
            this.tabTotals.Controls.Add(this.spinOthersRate);
            this.tabTotals.Controls.Add(this.spinSalesTax);
            this.tabTotals.Controls.Add(this.txtDiscountAmount);
            this.tabTotals.Controls.Add(this.spinDiscountRate);
            this.tabTotals.Controls.Add(this.txtSubtotal);
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
            // textOtherAmount
            // 
            this.textOtherAmount.Location = new System.Drawing.Point(307, 68);
            this.textOtherAmount.Name = "textOtherAmount";
            this.textOtherAmount.Size = new System.Drawing.Size(100, 20);
            this.textOtherAmount.TabIndex = 17;
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
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(98, 151);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 14;
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
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(98, 98);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
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
            this.lblOtherAmount.Location = new System.Drawing.Point(235, 71);
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
            this.lblDiscountAmount.Location = new System.Drawing.Point(7, 154);
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
            this.cmdCancel.Location = new System.Drawing.Point(342, 250);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(240, 250);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Guardar";
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
            this.ClientSize = new System.Drawing.Size(432, 285);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCxcApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManagementApproval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeller.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.tabTotals.ResumeLayout(false);
            this.tabTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOtherAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOthersRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalesTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscountRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtSeller;
        private DevExpress.XtraEditors.TextEdit txtFamily;
        private DevExpress.XtraEditors.TextEdit txtClient;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblFamily;
        private DevExpress.XtraEditors.LabelControl lblSeller;
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
        private DevExpress.XtraEditors.TextEdit textOtherAmount;
        private DevExpress.XtraEditors.SpinEdit spinOthersRate;
        private DevExpress.XtraEditors.SpinEdit spinSalesTax;
        private DevExpress.XtraEditors.TextEdit txtDiscountAmount;
        private DevExpress.XtraEditors.SpinEdit spinDiscountRate;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
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
    }
}