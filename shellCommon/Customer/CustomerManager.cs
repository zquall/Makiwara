using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using shellCommon.Contact;

namespace shellCommon.Customer
{
    public partial class CustomerManager : DevExpress.XtraEditors.XtraForm
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            var dialogResult = new ContactManager().ShowDialog();
        }
    }
}