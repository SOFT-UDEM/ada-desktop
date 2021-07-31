
namespace Equipos_Tecnologicos
{
    partial class Frm_Inventario_costos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdsoftDataSet3 = new Equipos_Tecnologicos.bdsoftDataSet3();
            this.Vw_ListaDeInventarioCostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vw_ListaDeInventarioCostosTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet3TableAdapters.Vw_ListaDeInventarioCostosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeInventarioCostosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1InventarioCostos";
            reportDataSource2.Value = this.Vw_ListaDeInventarioCostosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.InventarioCostos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdsoftDataSet3
            // 
            this.bdsoftDataSet3.DataSetName = "bdsoftDataSet3";
            this.bdsoftDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_ListaDeInventarioCostosBindingSource
            // 
            this.Vw_ListaDeInventarioCostosBindingSource.DataMember = "Vw_ListaDeInventarioCostos";
            this.Vw_ListaDeInventarioCostosBindingSource.DataSource = this.bdsoftDataSet3;
            // 
            // Vw_ListaDeInventarioCostosTableAdapter
            // 
            this.Vw_ListaDeInventarioCostosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Inventario_costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Inventario_costos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Cotos";
            this.Load += new System.EventHandler(this.Frm_Inventario_costos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeInventarioCostosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_ListaDeInventarioCostosBindingSource;
        private bdsoftDataSet3 bdsoftDataSet3;
        private bdsoftDataSet3TableAdapters.Vw_ListaDeInventarioCostosTableAdapter Vw_ListaDeInventarioCostosTableAdapter;
    }
}