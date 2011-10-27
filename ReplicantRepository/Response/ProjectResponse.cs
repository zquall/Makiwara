using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class ProjectResponse
    {
        public List<ProjectData> ProjectList { get; set; }
    }

    public class ProjectData
    {
        public int? Id { get; set; }
        public int FamilyId { get; set; }
        public string Name { get; set; }
        public int BudgetRequestId { get; set; }
        public int CustumerId { get; set; }
        public string CustumerName { get; set; }
        public int EmployeeId { get; set; }
        public bool ManagementApproval { get; set; }
        public bool CxcApproval { get; set; }
        public DateTime CreateDate { get; set; }
        public double ContingenciesRate { get; set; }
        public double GuaranteeRate { get; set; }
        public double TotalUtilityRate { get; set; }
        public double DiscountRate { get; set; }
        public double SalesTax { get; set; }
        public double OthersRate { get; set; }
        public string Comments { get; set; }
    }
}
