using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace shellCommon.Customer
{
    public partial class CustomerFinder : DevExpress.XtraEditors.XtraForm
    {
        public CustomerFinder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void CustomerFinder_Shown(object sender, EventArgs e)
        {
            SearchCustomer("a");
        }

        #region Search Customers Service Calls
        private void SearchCustomer(string query)
        {

        }
        #endregion
    }
}