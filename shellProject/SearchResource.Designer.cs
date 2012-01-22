namespace shellProject
{
    partial class SearchResource
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
            this.grdResourceControl = new DevExpress.XtraGrid.GridControl();
            this.viewResourceSource = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResourceControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResourceSource)).BeginInit();
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
            // grdResourceControl
            // 
            this.grdResourceControl.Location = new System.Drawing.Point(12, 47);
            this.grdResourceControl.MainView = this.viewResourceSource;
            this.grdResourceControl.Name = "grdResourceControl";
            this.grdResourceControl.Size = new System.Drawing.Size(410, 200);
            this.grdResourceControl.TabIndex = 1;
            this.grdResourceControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewResourceSource});
            // 
            // viewResourceSource
            // 
            this.viewResourceSource.GridControl = this.grdResourceControl;
            this.viewResourceSource.Name = "viewResourceSource";
            this.viewResourceSource.OptionsView.ShowGroupPanel = false;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(252, 256);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(347, 256);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // SearchResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.grdResourceControl);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Recurso";
            this.Shown += new System.EventHandler(this.SearchResource_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResourceControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewResourceSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraGrid.GridControl grdResourceControl;
        private DevExpress.XtraGrid.Views.Grid.GridView viewResourceSource;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
    }
}