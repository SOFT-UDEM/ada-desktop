
namespace Equipos_Tecnologicos
{
    partial class Frm_listaEmpleadosPorAreas
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
            this.Vw_ListaEmpleadosPorAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsoftDataSet4 = new Equipos_Tecnologicos.bdsoftDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vw_ListaEmpleadosPorAreasTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet4TableAdapters.Vw_ListaEmpleadosPorAreasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaEmpleadosPorAreasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // Vw_ListaEmpleadosPorAreasBindingSource
            // 
            this.Vw_ListaEmpleadosPorAreasBindingSource.DataMember = "Vw_ListaEmpleadosPorAreas";
            this.Vw_ListaEmpleadosPorAreasBindingSource.DataSource = this.bdsoftDataSet4;
            // 
            // bdsoftDataSet4
            // 
            this.bdsoftDataSet4.DataSetName = "bdsoftDataSet4";
            this.bdsoftDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1EmpleadosPorArea";
            reportDataSource1.Value = this.Vw_ListaEmpleadosPorAreasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.EmpleadosPorAreas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Vw_ListaEmpleadosPorAreasTableAdapter
            // 
            this.Vw_ListaEmpleadosPorAreasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_listaEmpleadosPorAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_listaEmpleadosPorAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de empleados por areas";
            this.Load += new System.EventHandler(this.Frm_listaEmpleadosPorAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaEmpleadosPorAreasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_ListaEmpleadosPorAreasBindingSource;
        private bdsoftDataSet4 bdsoftDataSet4;
        private bdsoftDataSet4TableAdapters.Vw_ListaEmpleadosPorAreasTableAdapter Vw_ListaEmpleadosPorAreasTableAdapter;
    }
}