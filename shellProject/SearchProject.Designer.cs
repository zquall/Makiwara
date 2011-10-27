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
            this.txtFind = new DevExpress.XtraEditors.TextEdit();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.grdProjectControl = new DevExpress.XtraGrid.GridControl();
            this.viewProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.EditValue = "Dato a Buscar";
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(410, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.EditValueChanged += new System.EventHandler(this.txtFind_EditValueChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(347, 256);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(252, 256);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            // 
            // grdProjectControl
            // 
            this.grdProjectControl.Location = new System.Drawing.Point(12, 47);
            this.grdProjectControl.MainView = this.viewProjects;
            this.grdProjectControl.Name = "grdProjectControl";
            this.grdProjectControl.Size = new System.Drawing.Size(410, 200);
            this.grdProjectControl.TabIndex = 3;
            this.grdProjectControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewProjects});
            // 
            // viewProjects
            // 
            this.viewProjects.GridControl = this.grdProjectControl;
            this.viewProjects.Name = "viewProjects";
            this.viewProjects.OptionsView.ShowGroupPanel = false;
            // 
            // SearchProject
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.grdProjectControl);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Proyecto";
            this.Shown += new System.EventHandler(this.SearchProject_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraGrid.GridControl grdProjectControl;
        private DevExpress.XtraGrid.Views.Grid.GridView viewProjects;
    }
}