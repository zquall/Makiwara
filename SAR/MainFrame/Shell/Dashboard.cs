using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.Request;
using DevExpress.XtraNavBar;
using ReplicantRepository.Response;
using shellProject;

namespace MainFrame.Shell
{
    public partial class Dashboard : XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadNavigationBar();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region NavigationBar Loading

        private void LoadNavigationBar()
        {
            var request = new MenuRequest {NavigationGroupCode = "Project"};
            var response = new MenuFactory().getNavigationItemList(request);
            if (response.NavigationItemList != null) 
            {
                LinkItemsWithGroups(navBarGroupProject, response.NavigationItemList);               
            }
        }

        private void LinkItemsWithGroups(NavBarGroup navBarGroup, List<NavigationItem> navBarItemList)
        {
            foreach (var item in navBarItemList)
            {
                var tmpNavBarItem = navBarControlDashboard.Items.Add();
                tmpNavBarItem.Caption = item.Caption;
                tmpNavBarItem.Name = item.Code;
                navBarGroup.ItemLinks.Add(tmpNavBarItem);
            }
        }

        #endregion

        #region Menu  Options

        private void BudgetRequest()
        {
            var requestBugetManager = new BudgetRequestManager {MdiParent = this};
            requestBugetManager.Show();
        }

        private void CreateProject()
        {
            var projectManager = new ProjectManager {MdiParent = this};
            projectManager.Show();

            var createProject = new CreateProject();
            if (createProject.ShowDialog() == DialogResult.Cancel)
                projectManager.Close();
            else
                projectManager.LoadProject(createProject.Tag as ProjectDto);
        }

        private void SearchProject()
        {
            var projectManager = new ProjectManager {MdiParent = this};
            projectManager.Show();

            var searchProject = new SearchProject();
            if (searchProject.ShowDialog() == DialogResult.Cancel)
                projectManager.Close();
            else
                projectManager.LoadProject(searchProject.ProjectSelected);
        }

        private void navBarControlDashboard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            switch (e.Link.ItemName)
            {
                case "BugetRequest":
                    BudgetRequest();
                    break;
                case "CreateProject":
                    CreateProject();
                    break;
                case "SearchProject":
                    SearchProject();
                    break;

                default:
                    MessageBox.Show("[ " + e.Link.ItemName + " ] menu not implemented");
                    break;
            }
        }

        #endregion
    }    
}