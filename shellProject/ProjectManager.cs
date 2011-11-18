using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
using Infragistics.Win.UltraWinSchedule;

namespace shellProject
{
    public partial class ProjectManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ProjectData _project = new ProjectData();

        public ProjectManager()
        {
            InitializeComponent();
        }

        private Project getProject()
        {
            Project tmpProject = new Project();
            tmpProject.Name = _project.Name;
            return tmpProject;
        }

        private void chargeTasks()
        {
            foreach (TaskData t in _project.taskList)
            {
                Task tmpTask = new Task();

                //tmpTask.Id = t.Id;
                //tmpTask.ProjectKey = t.ProjectId;
                //tmpTask.Parent = ultraCalendarInfo.Tasks[t.ParentId];
                tmpTask.Name = t.Name;
                tmpTask.Duration = t.Duration;
                tmpTask.PercentComplete = (float)t.PercentComplete;
                tmpTask.StartDateTime = t.StartDateTime;
                tmpTask.EndDateTime = t.EndDateTime;
                tmpTask.Notes = t.Notes;
                //tmpTask.RowNumber = t.Rownumber;
                //tmpTask.BindingListIndex = t.BindingListindex;
                //tmpTask.CompleteThrough = t.CompleteThrough;
                tmpTask.Deadline = t.DeadLine;
                //tmpTask.DurationResolved = t.DurationResolved;
                //tmpTask.EndDateTimeResolved = t.EndDateTimeResolved;
                tmpTask.Expanded = t.Expanded;
                //tmpTask.IsRoot = t.IsRoot;
                //tmpTask.IsSummary = t.IsSumary;
                //tmpTask.Level = t.TaskLevel;
                tmpTask.Milestone = t.Milestone;
                //tmpTask.MilestoneResolved = t.MilestoneResolved;
                ultraCalendarInfo.Tasks.Add(tmpTask);
            }
            
        }

        public void chargeProject(ProjectData project)
        {
            _project = project;

            repositoryItemProject.NullText = _project.Id.ToString();
            repositoryItemProjectName.NullText = _project.Name;
            repositoryItemCustumer.NullText = _project.CustumerName;

            //projectGantt.Project = getProject();
            chargeTasks();
        }

        private void createProject()
        { 
            CreateProject cp = new CreateProject();
            cp.Text = "Crear Proyecto";
            cp.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Name == "barButtonCreateProject")
                createProject();
        }
    }
}