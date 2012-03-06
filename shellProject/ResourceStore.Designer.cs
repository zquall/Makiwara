namespace shellProject
{
    partial class ResourceStore
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
            this.grdResources = new DevExpress.XtraGrid.GridControl();
            this.viewResources = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTask = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdResources
            // 
            this.grdResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdResources.Location = new System.Drawing.Point(0, 0);
            this.grdResources.MainView = this.viewResources;
            this.grdResources.Name = "grdResources";
            this.grdResources.Size = new System.Drawing.Size(773, 270);
            this.grdResources.TabIndex = 3;
            this.grdResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewResources});
            // 
            // viewResources
            // 
            this.viewResources.GridControl = this.grdResources;
            this.viewResources.Name = "viewResources";
            this.viewResources.OptionsBehavior.Editable = false;
            this.viewResources.OptionsBehavior.ReadOnly = true;
            this.viewResources.OptionsCustomization.AllowColumnMoving = false;
            this.viewResources.OptionsCustomization.AllowColumnResizing = false;
            this.viewResources.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewResources.OptionsView.EnableAppearanceEvenRow = true;
            this.viewResources.OptionsView.ShowFooter = true;
            this.viewResources.OptionsView.ShowGroupPanel = false;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(0, 0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.CmdOkClick);
            // 
            // cmbTask
            // 
            this.cmbTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTask.Location = new System.Drawing.Point(0, 0);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTask.Size = new System.Drawing.Size(773, 20);
            this.cmbTask.TabIndex = 2;
            this.cmbTask.TabStop = false;
            this.cmbTask.EditValueChanged += new System.EventHandler(this.CmbTaskEditValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(773, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 314);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(773, 46);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdOk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(696, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 26);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdResources);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 270);
            this.panel4.TabIndex = 7;
            // 
            // ResourceStore
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 370);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ResourceStore";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ResourceStoreLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdResources;
        private DevExpress.XtraGrid.Views.Grid.GridView viewResources;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}