using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
using System.Linq;

namespace shellProject
{
    public partial class CreateProject : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Variable encargada de almacenar los datos del projecto
        /// </summary>
        private ProjectData _project = new ProjectData();

        public CreateProject()
        {
            InitializeComponent();
        }


        #region UI Events

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Save Process

        private void captureProject()
        {
            //_project.Id = ;
            //_project.Family = ;
            //_project.BudgetRequestId = ;
            //_project.CustumerId = ;
            //_project.EmployeeId = ;

            _project.Name = txtProject.Text;
            _project.ManagementApproval = chkManagementApproval.Checked;
            _project.CxcApproval = chkCxcApproval.Checked;
            _project.CreateDate = dtCreateDate.DateTime;
            _project.ContingenciesRate = (double)spinContingenciesRate.Value;
            _project.GuaranteeRate = (double)spinGuaranteeRate.Value;
            _project.TotalUtilityRate = (double)spinTotalUtilityRate.Value;
            _project.DiscountRate = (double)spinDiscountRate.Value;
            _project.SalesTax = (double)spinSalesTax.Value;
            _project.OthersRate = (double)spinOthersRate.Value;
            _project.Comments = memoComments.Text;
        }


        #endregion
    }
}