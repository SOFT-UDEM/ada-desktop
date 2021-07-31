
namespace Equipos_Tecnologicos
{
    partial class Frm_areas
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
            this.AreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsoftDataSet8 = new Equipos_Tecnologicos.bdsoftDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AreasTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet8TableAdapters.AreasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AreasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // AreasBindingSource
            // 
            this.AreasBindingSource.DataMember = "Areas";
            this.AreasBindingSource.DataSource = this.bdsoftDataSet8;
            // 
            // bdsoftDataSet8
            // 
            this.bdsoftDataSet8.DataSetName = "bdsoftDataSet8";
            this.bdsoftDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1Areas";
            reportDataSource1.Value = this.AreasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.areas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AreasTableAdapter
            // 
            this.AreasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_areas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de las areas";
            this.Load += new System.EventHandler(this.Frm_areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AreasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AreasBindingSource;
        private bdsoftDataSet8 bdsoftDataSet8;
        private bdsoftDataSet8TableAdapters.AreasTableAdapter AreasTableAdapter;
    }
}