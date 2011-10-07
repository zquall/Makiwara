using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace shellProject
{
    public partial class ProjectManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProjectManager()
        {
            InitializeComponent();
        }

        private void createProject()
        { 
            CreateProject cp = new CreateProject();
            cp.Text = "Crear Proyecto";
            cp.MdiParent = this.MdiParent;
            cp.Show();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Name == "barButtonCreateProject")
                createProject();
        }
    }
}