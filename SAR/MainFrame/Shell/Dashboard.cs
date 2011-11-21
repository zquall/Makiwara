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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadNavigationBar();
        }

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

        private void navBarControlDashboard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ProjectManager projectManager;

            switch (e.Link.ItemName)
            {

                case "BugetRequest":
                    BudgetRequestManager requestBugetManager = new BudgetRequestManager();
                    requestBugetManager.MdiParent = this;
                    requestBugetManager.Show();
                    break;

                case "CreateProject":
                    projectManager = new ProjectManager();
                    projectManager.MdiParent = this;
                    projectManager.Show();

                    CreateProject createProject = new CreateProject();

                    createProject.ShowDialog();
                    //if (createProject.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        //projectManager.Close();
                    //else
                    //    MessageBox.Show("Cargando Datos del Proyecto");

                    break;

                case "SearchProject":
                    projectManager = new ProjectManager();
                    projectManager.MdiParent = this;
                    projectManager.Show();

                    SearchProject searchProject = new SearchProject();

                    if (searchProject.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        projectManager.Close();
                    else
                    {
                        projectManager.chargeProject(searchProject.projectSelected);
                    }

                    break;

                default:
                    MessageBox.Show("[ " + e.Link.ItemName + " ] menu not implemented");
                    break;
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }       
    }    
}