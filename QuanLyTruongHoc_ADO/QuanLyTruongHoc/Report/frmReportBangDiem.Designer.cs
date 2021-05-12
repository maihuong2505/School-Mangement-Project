namespace QuanLyTruongHoc.Reports
{
    partial class frmReportBangDiem
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportBangDiem));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLTH_DataSet = new QuanLyTruongHoc.QLTH_DataSet();
            this.qLTHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemTableAdapter = new QuanLyTruongHoc.QLTH_DataSetTableAdapters.BangDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLTH_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bangDiemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTruongHoc.ReportBangDiem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLTH_DataSet
            // 
            this.qLTH_DataSet.DataSetName = "QLTH_DataSet";
            this.qLTH_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTHDataSetBindingSource
            // 
            this.qLTHDataSetBindingSource.DataSource = this.qLTH_DataSet;
            this.qLTHDataSetBindingSource.Position = 0;
            // 
            // qLTHDataSetBindingSource1
            // 
            this.qLTHDataSetBindingSource1.DataSource = this.qLTH_DataSet;
            this.qLTHDataSetBindingSource1.Position = 0;
            // 
            // bangDiemBindingSource
            // 
            this.bangDiemBindingSource.DataMember = "BangDiem";
            this.bangDiemBindingSource.DataSource = this.qLTH_DataSet;
            // 
            // bangDiemTableAdapter
            // 
            this.bangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReportHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm học sinh";
            this.Load += new System.EventHandler(this.FrmReportDiemHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTH_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLTHDataSetBindingSource;
        private QLTH_DataSet qLTH_DataSet;
        private System.Windows.Forms.BindingSource qLTHDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bangDiemBindingSource;
        private QLTH_DataSetTableAdapters.BangDiemTableAdapter bangDiemTableAdapter;
    }
}