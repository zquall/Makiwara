namespace shellCommon.Contact
{
    partial class ContactManager
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtJob = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbPhoneTypeC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPhoneTypeB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPhoneTypeA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPhoneC = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneB = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneA = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Apellidos";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Puesto";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "E-Mail";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(60, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(60, 77);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(200, 20);
            this.txtJob.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbPhoneTypeC);
            this.groupControl1.Controls.Add(this.cmbPhoneTypeB);
            this.groupControl1.Controls.Add(this.cmbPhoneTypeA);
            this.groupControl1.Controls.Add(this.txtPhoneC);
            this.groupControl1.Controls.Add(this.txtPhoneB);
            this.groupControl1.Controls.Add(this.txtPhoneA);
            this.groupControl1.Location = new System.Drawing.Point(287, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(203, 131);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Telefonos";
            // 
            // cmbPhoneTypeC
            // 
            this.cmbPhoneTypeC.Location = new System.Drawing.Point(5, 85);
            this.cmbPhoneTypeC.Name = "cmbPhoneTypeC";
            this.cmbPhoneTypeC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhoneTypeC.Size = new System.Drawing.Size(85, 20);
            this.cmbPhoneTypeC.TabIndex = 14;
            // 
            // cmbPhoneTypeB
            // 
            this.cmbPhoneTypeB.Location = new System.Drawing.Point(5, 56);
            this.cmbPhoneTypeB.Name = "cmbPhoneTypeB";
            this.cmbPhoneTypeB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhoneTypeB.Size = new System.Drawing.Size(85, 20);
            this.cmbPhoneTypeB.TabIndex = 13;
            // 
            // cmbPhoneTypeA
            // 
            this.cmbPhoneTypeA.Location = new System.Drawing.Point(5, 27);
            this.cmbPhoneTypeA.Name = "cmbPhoneTypeA";
            this.cmbPhoneTypeA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhoneTypeA.Size = new System.Drawing.Size(85, 20);
            this.cmbPhoneTypeA.TabIndex = 12;
            // 
            // txtPhoneC
            // 
            this.txtPhoneC.Location = new System.Drawing.Point(96, 85);
            this.txtPhoneC.Name = "txtPhoneC";
            this.txtPhoneC.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneC.TabIndex = 11;
            // 
            // txtPhoneB
            // 
            this.txtPhoneB.Location = new System.Drawing.Point(96, 56);
            this.txtPhoneB.Name = "txtPhoneB";
            this.txtPhoneB.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneB.TabIndex = 10;
            // 
            // txtPhoneA
            // 
            this.txtPhoneA.Location = new System.Drawing.Point(96, 27);
            this.txtPhoneA.Name = "txtPhoneA";
            this.txtPhoneA.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneA.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(334, 149);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Aceptar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(415, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtName);
            this.groupControl2.Controls.Add(this.txtLastName);
            this.groupControl2.Controls.Add(this.txtJob);
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(267, 131);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Datos del Cliente";
            // 
            // ContactManager
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(501, 181);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupControl1);
            this.Name = "ContactManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestor de Contactos";
            this.Load += new System.EventHandler(this.ContactManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhoneTypeA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtJob;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPhoneC;
        private DevExpress.XtraEditors.TextEdit txtPhoneB;
        private DevExpress.XtraEditors.TextEdit txtPhoneA;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPhoneTypeC;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPhoneTypeB;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPhoneTypeA;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}