using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class ProjectData
    {
        public int Id { get; set; }
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
        public int RowNumber { get; set; }
        public int BindingListIndex { get; set; }
        public DateTime CompleteThrough { get; set; }
        public DateTime DeadLine { get; set; }
        public TimeSpan DurationResolved { get; set; }
        public DateTime EndDateTimeResolved { get; set; }
        public bool Expanded { get; set; }
        public bool IsRoot { get; set; }
        public bool IsSummary { get; set; }
        public int TaskLevel { get; set; }
        public bool Milestone { get; set; }
        public bool MilestoneResolved { get; set; }

        public List<TaskData> Dependencies { get; set; }
        public List<ResourceData> resourceList { get; set; }
    }

    public class ResourceData
    {
        public Int64 Id { get; set; }
        public int ProjectId { get; set; }
        public Int64 TaskId { get; set; }
        public MeasureData Measure { get; set; }
        public ResourceTypeData ResourceType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public double RealUsed { get; set; }
    }

    public class MeasureData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return Symbol;
        }
    }

    public class ResourceTypeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTaxed { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
