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
        public int Id { get; set; }
        public FamilyData Family { get; set; }
        public int BudgetRequestId { get; set; }
        public int CustumerId { get; set; }
        public string CustumerName { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
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

        public List<TaskData> taskList { get; set; }
    }

    public class FamilyData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TaskData
    {
        public Int64 Id { get; set; }
        public int ProjectId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public double PercentComplete { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Notes { get; set; }
        public int Rownumber { get; set; }
        public int BindingListindex { get; set; }
        public DateTime CompleteThrough { get; set; }
        public DateTime DeadLine { get; set; }
        public TimeSpan DurationResolved { get; set; }
        public DateTime EndDateTimeResolved { get; set; }
        public bool Expanded { get; set; }
        public bool IsRoot { get; set; }
        public bool IsSumary { get; set; }
        public int TaskLevel { get; set; }
        public bool Milestone { get; set; }
        public bool MilestoneResolved { get; set; }

        public List<TaskData> Dependencies { get; set; }
        public List<ResourceData> resourceList { get; set; }
    }

    public class ResourceData
    {
        public int Id { get; set; }
        public int MeasureId { get; set; }
        public ResourcceTypeData ResourceType { get; set; }
        public int TaskId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public double Cost { get; set; }
        public double TotalCost { get; set; }
        public float RealUsed { get; set; }
    }

    public class ResourcceTypeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTaxed { get; set; }
    }
}
