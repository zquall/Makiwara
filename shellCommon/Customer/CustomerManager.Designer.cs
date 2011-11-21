namespace shellCommon.Customer
{
    partial class CustomerManager
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbContacts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEditContact = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContacts.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre del Cliente";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(108, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(330, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(258, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fax";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Telefono";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(282, 35);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(156, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(108, 35);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(144, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Direccion";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(108, 63);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(330, 20);
            this.textEdit4.TabIndex = 7;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(108, 89);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(330, 20);
            this.textEdit5.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbContacts);
            this.groupControl1.Controls.Add(this.btnEditContact);
            this.groupControl1.Location = new System.Drawing.Point(12, 115);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 55);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Contacto Principal";
            // 
            // cmbContacts
            // 
            this.cmbContacts.Location = new System.Drawing.Point(96, 26);
            this.cmbContacts.Name = "cmbContacts";
            this.cmbContacts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.cmbContacts.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbContacts_Properties_ButtonClick);
            this.cmbContacts.Size = new System.Drawing.Size(325, 20);
            this.cmbContacts.TabIndex = 13;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(5, 25);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(85, 23);
            this.btnEditContact.TabIndex = 12;
            this.btnEditContact.Text = "Editar";
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(363, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerManager
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestor de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbContacts.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEditContact;
        private DevExpress.XtraEditors.ComboBoxEdit cmbContacts;
    }
}