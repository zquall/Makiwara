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

        public ProjectResponse searchProject(ProjectRequest request)
        {
            const int maximunResultRows = 10;

            var response = new ProjectResponse();
            // Inicitialize the list of customers
            response.ProjectList = new List<ProjectData>();

            // Get customers from respective employee
            //var tmpEmployee = Olympus._Enterprise.Employees.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();
            // Apply the search with the pattern given
            //var customersFounded = tmpEmployee.Customers.Where(x => x.Name.ToUpperInvariant().Contains(request.SearchCustomerQuery.ToUpperInvariant())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();

            //var projectFounded = Olympus._Enterprise.Projects.Where(x => x.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            var projectFounded = Olympus._Enterprise.Projects.Where(x => x.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();

            if (projectFounded != null)
            {
                // Fill the response with the customers founded
                foreach (var project in projectFounded)
                {
                    ProjectData tmpProjectData = new ProjectData();
                    tmpProjectData.Id = project.Id;
                    tmpProjectData.FamilyId = project.FamilyId;
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

                    response.ProjectList.Add(tmpProjectData);
                }
            }
            return response;
        }
    }
}
