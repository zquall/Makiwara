using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;

namespace CORE.Services
{
    public class ProjectService
    {
        public ProjectService()
        {
        }

        private FamilyData getFamily(Nexus.Family family)
        {
            FamilyData tmpFamilyData = new FamilyData();

            tmpFamilyData.Id = family.Id;
            tmpFamilyData.Name = family.Name;

            return tmpFamilyData;
        }

        private List<TaskData> getTasks(System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks)
        {
            List<TaskData> listTask = new List<TaskData>();

            if (tasks != null)
            {
                foreach (Nexus.Task task in tasks)
                {
                    TaskData tmpTask = new TaskData();

                    tmpTask.Id = task.Id;
                    tmpTask.ProjectId = task.ProjectId;
                    tmpTask.ParentId = task.ParentId;
                    tmpTask.Name = task.Name;
                    tmpTask.Duration = TimeSpan.Parse(task.Duration);
                    tmpTask.PercentComplete = task.PercentComplete;
                    tmpTask.StartDateTime = task.StartDateTime;
                    tmpTask.EndDateTime = task.EndDateTime;
                    tmpTask.Notes = task.Notes;
                    tmpTask.Rownumber = task.RowNumber;
                    tmpTask.BindingListindex = task.BindingListIndex;
                    tmpTask.CompleteThrough = task.CompleteThrough;
                    tmpTask.DeadLine = task.DeadLine;
                    tmpTask.DurationResolved = TimeSpan.Parse(task.DurationResolved);
                    tmpTask.EndDateTimeResolved = task.EndDateTimeResolved;
                    tmpTask.Expanded = task.Expanded;
                    tmpTask.IsRoot = task.IsRoot;
                    tmpTask.IsSumary = task.IsSumary;
                    tmpTask.TaskLevel = task.TaskLevel;
                    tmpTask.Milestone = task.Milestone;
                    tmpTask.MilestoneResolved = task.MilestoneResolved;

                    listTask.Add(tmpTask);
                }
            }

            return listTask;
        }

        private List<ProjectData> getProjects(List<Nexus.Project> projectFounded)
        {
            List<ProjectData> ProjectList = new List<ProjectData>();

            if (projectFounded != null)
            {
                // Fill the response with the customers founded
                foreach (var project in projectFounded)
                {
                    ProjectData tmpProjectData = new ProjectData();

                    tmpProjectData.Id = project.Id;
                    tmpProjectData.Family = getFamily(project.Family);
                    tmpProjectData.Name = project.Name;
                    tmpProjectData.BudgetRequestId = project.BudgetRequestId;
                    tmpProjectData.CustumerId = project.CustumerId;
                    tmpProjectData.CustumerName = project.Customer.Name;
                    tmpProjectData.EmployeeId = project.EmployeeId;
                    tmpProjectData.ManagementApproval = project.ManagementApproval;
                    tmpProjectData.CxcApproval = project.CxcApproval;
                    tmpProjectData.CreateDate = project.CreateDate;
                    tmpProjectData.ContingenciesRate = project.ContingenciesRate;
                    tmpProjectData.GuaranteeRate = project.GuaranteeRate;
                    tmpProjectData.TotalUtilityRate = project.TotalUtilityRate;
                    tmpProjectData.DiscountRate = project.DiscountRate;
                    tmpProjectData.SalesTax = project.SalesTax;
                    tmpProjectData.OthersRate = project.OthersRate;
                    tmpProjectData.Comments = project.Comments;

                    tmpProjectData.taskList = getTasks(project.Tasks);

                    ProjectList.Add(tmpProjectData);
                }
            }


            return ProjectList;
        }

        public ProjectResponse searchProject(ProjectRequest request)
        {
            const int maximunResultRows = 20;

            var response = new ProjectResponse();

            // Inicitialize the list of customers
            response.ProjectList = new List<ProjectData>();   

            //var projectFoundedById = Olympus._Enterprise.Projects.Where(x => x.Id.Contains(request.SearchProjectQuery)).OrderBy(y => y.Id).Take(maximunResultRows).ToList();
            var projectFoundedByName = Olympus._Enterprise.Projects.Where(x => x.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            var projectFoundedByCustumer = Olympus._Enterprise.Projects.Where(x => x.Customer.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Customer.Name).Take(maximunResultRows).ToList();

            response.ProjectList.AddRange(getProjects(projectFoundedByName));
            response.ProjectList.AddRange(getProjects(projectFoundedByCustumer));

            
            return response;
        }
    }
}
