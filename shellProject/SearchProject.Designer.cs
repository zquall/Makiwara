namespace shellProject
{
    partial class SearchProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchQuery = new DevExpress.XtraEditors.TextEdit();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.grdProjectControl = new DevExpress.XtraGrid.GridControl();
            this.viewProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchQuery.EditValue = "";
            this.txtSearchQuery.Location = new System.Drawing.Point(0, 0);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(396, 20);
            this.txtSearchQuery.TabIndex = 0;
            this.txtSearchQuery.EditValueChanged += new System.EventHandler(this.TxtSearchQueryEditValueChanged);
            this.txtSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchQueryKeyDown);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(0, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancelClick);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(0, 3);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.CmdOkClick);
            // 
            // grdProjectControl
            // 
            this.grdProjectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProjectControl.Location = new System.Drawing.Point(0, 0);
            this.grdProjectControl.MainView = this.viewProjects;
            this.grdProjectControl.Name = "grdProjectControl";
            this.grdProjectControl.Size = new System.Drawing.Size(396, 191);
            this.grdProjectControl.TabIndex = 3;
            this.grdProjectControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewProjects});
            // 
            // viewProjects
            // 
            this.viewProjects.GridControl = this.grdProjectControl;
            this.viewProjects.Name = "viewProjects";
            this.viewProjects.OptionsBehavior.Editable = false;
            this.viewProjects.OptionsBehavior.ReadOnly = true;
            this.viewProjects.OptionsCustomization.AllowColumnMoving = false;
            this.viewProjects.OptionsCustomization.AllowColumnResizing = false;
            this.viewProjects.OptionsDetail.EnableMasterViewMode = false;
            this.viewProjects.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewProjects.OptionsView.EnableAppearanceEvenRow = true;
            this.viewProjects.OptionsView.ShowGroupPanel = false;
            this.viewProjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewProjectsKeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(396, 31);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 232);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(396, 39);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdOk);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(224, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 29);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(321, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 29);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grdProjectControl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 191);
            this.panel5.TabIndex = 6;
            // 
            // SearchProject
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(416, 281);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "SearchProject";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.SearchProjectShown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearchQuery;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraGrid.GridControl grdProjectControl;
        private DevExpress.XtraGrid.Views.Grid.GridView viewProjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}