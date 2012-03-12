using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace shellProject
{
    public partial class Calendar : DevExpress.XtraEditors.XtraForm
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void lblWorkday_Click(object sender, EventArgs e)
        {

        }

        private void spinWorkday_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblWorkweek_Click(object sender, EventArgs e)
        {

        }

        private void spinWorkweek_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDaysXMonth_Click(object sender, EventArgs e)
        {

        }

        private void spinDaysXMonth_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}