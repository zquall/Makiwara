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
            this.grdFind = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.EditValue = "Dato a Buscar";
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(425, 20);
            this.txtFind.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(362, 335);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(265, 335);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Aceptar";
            // 
            // grdFind
            // 
            this.grdFind.Location = new System.Drawing.Point(12, 47);
            this.grdFind.MainView = this.gridView1;
            this.grdFind.Name = "grdFind";
            this.grdFind.Size = new System.Drawing.Size(425, 276);
            this.grdFind.TabIndex = 3;
            this.grdFind.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdFind;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SearchProject
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(449, 364);
            this.Controls.Add(this.grdFind);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraGrid.GridControl grdFind;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}