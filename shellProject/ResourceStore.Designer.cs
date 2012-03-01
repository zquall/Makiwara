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
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResources
            // 
            this.grdResources.Location = new System.Drawing.Point(12, 38);
            this.grdResources.MainView = this.viewResources;
            this.grdResources.Name = "grdResources";
            this.grdResources.Size = new System.Drawing.Size(617, 384);
            this.grdResources.TabIndex = 3;
            this.grdResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewResources});
            // 
            // viewResources
            // 
            this.viewResources.GridControl = this.grdResources;
            this.viewResources.Name = "viewResources";
            this.viewResources.OptionsView.ShowFooter = true;
            this.viewResources.OptionsView.ShowGroupPanel = false;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(554, 439);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.CmdOkClick);
            // 
            // cmbTask
            // 
            this.cmbTask.Location = new System.Drawing.Point(12, 12);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTask.Size = new System.Drawing.Size(617, 20);
            this.cmbTask.TabIndex = 2;
            this.cmbTask.TabStop = false;
            this.cmbTask.EditValueChanged += new System.EventHandler(this.CmbTaskEditValueChanged);
            // 
            // ResourceStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.grdResources);
            this.Controls.Add(this.cmbTask);
            this.Name = "ResourceStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ResourceStoreLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grdResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdResources;
        private DevExpress.XtraGrid.Views.Grid.GridView viewResources;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbTask;

    }
}