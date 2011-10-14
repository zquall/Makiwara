using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    class ProjectResponse
    {
        public int? Id { get; set; }
        public int FamilyId { get; set; }
        public string Name { get; set; }
        public int BudgetRequestId  { get; set; }
        public int CustumerId  { get; set; }
        public int SellerId { get; set; }
        public bool ManagementApproval { get; set; }
        public bool CxcApproval { get; set; }
        public DateTime CreateDate { get; set; }
        public float ContingenciesRate { get; set; }
        public float GuaranteeRate { get; set; }
        public float TotalUtilityRate { get; set; }
        public float DiscoutRate { get; set; }
        public float SalesTax { get; set; }
        public float OthersRate { get; set; }
        public string Comments { get; set; }
    }
}
