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
            switch (e.Link.ItemName)
            {

                case "BugetRequest":
                    RequestBugetManager requestBugetManager = new RequestBugetManager();
                    requestBugetManager.MdiParent = this;
                    requestBugetManager.Show();
                    break;
                default:
                    MessageBox.Show("[ " + e.Link.ItemName + " ] menu not implemented");
                    break;
            }
        }
                
    }    
}