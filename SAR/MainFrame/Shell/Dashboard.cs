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
using DevExpress.XtraNavBar;
using ReplicantRepository.Response;
using shellProject;

namespace MainFrame.Shell
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadNavigationBar();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region NavigationBar Loading

        private void loadNavigationBar()
        {
            var request = new MenuRequest();
            request.NavigationGroupCode = "Project";
            var response = new MenuFactory().getNavigationItemList(request);
            if (response.NavigationItemList != null) 
            {
                linkItemsWithGroups(navBarGroupProject, response.NavigationItemList);               
            }
        }

        private void linkItemsWithGroups(NavBarGroup navBarGroup, List<NavigationItem> navBarItemList)
        {
            foreach (var item in navBarItemList)
            {
                NavBarItem tmpNavBarItem = navBarControlDashboard.Items.Add();
                tmpNavBarItem.Caption = item.Caption;
                tmpNavBarItem.Name = item.Code;
                navBarGroup.ItemLinks.Add(tmpNavBarItem);
            }
        }

        #endregion

        #region Menu  Options

        private void budgetRequest()
        {
            BudgetRequestManager requestBugetManager = new BudgetRequestManager();
            requestBugetManager.MdiParent = this;
            requestBugetManager.Show();
        }

        private void createProject()
        {
            ProjectManager projectManager = new ProjectManager();
            projectManager.MdiParent = this;
            projectManager.Show();

            CreateProject createProject = new CreateProject();
            if (createProject.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                projectManager.Close();
        }

        private void searchProject()
        {
            ProjectManager projectManager = new ProjectManager();
            projectManager.MdiParent = this;
            projectManager.Show();

            SearchProject searchProject = new SearchProject();
            if (searchProject.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                projectManager.Close();
            else
            {
                projectManager.loadProject(searchProject.ProjectSelected);
            }
        }

        private void navBarControlDashboard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            switch (e.Link.ItemName)
            {
                case "BugetRequest":
                    budgetRequest();
                    break;
                case "CreateProject":
                    createProject();
                    break;
                case "SearchProject":
                    searchProject();
                    break;

                default:
                    MessageBox.Show("[ " + e.Link.ItemName + " ] menu not implemented");
                    break;
            }
        }

        #endregion
    }    
}