
namespace Equipos_Tecnologicos
{
    partial class Frm_ListaDeEquipoPorAreas
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
            this.Vw_ListaDeEquiposPorAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsoftDataSet7 = new Equipos_Tecnologicos.bdsoftDataSet7();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vw_ListaDeEquiposPorAreasTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet7TableAdapters.Vw_ListaDeEquiposPorAreasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeEquiposPorAreasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // Vw_ListaDeEquiposPorAreasBindingSource
            // 
            this.Vw_ListaDeEquiposPorAreasBindingSource.DataMember = "Vw_ListaDeEquiposPorAreas";
            this.Vw_ListaDeEquiposPorAreasBindingSource.DataSource = this.bdsoftDataSet7;
            // 
            // bdsoftDataSet7
            // 
            this.bdsoftDataSet7.DataSetName = "bdsoftDataSet7";
            this.bdsoftDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1EquiposPorAreas";
            reportDataSource1.Value = this.Vw_ListaDeEquiposPorAreasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.ListaDeEquiposPorAreas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Vw_ListaDeEquiposPorAreasTableAdapter
            // 
            this.Vw_ListaDeEquiposPorAreasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ListaDeEquipoPorAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ListaDeEquipoPorAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de equipos por areas";
            this.Load += new System.EventHandler(this.Frm_ListaDeEquipoPorAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeEquiposPorAreasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_ListaDeEquiposPorAreasBindingSource;
        private bdsoftDataSet7 bdsoftDataSet7;
        private bdsoftDataSet7TableAdapters.Vw_ListaDeEquiposPorAreasTableAdapter Vw_ListaDeEquiposPorAreasTableAdapter;
    }
}