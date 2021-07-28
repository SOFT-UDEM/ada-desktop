
namespace Equipos_Tecnologicos
{
    partial class Frm_EntradaSalidaPersonalAreas
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
            this.bdsoftDataSet2 = new Equipos_Tecnologicos.bdsoftDataSet2();
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet2TableAdapters.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1EntradaSalidaPersonalArea";
            reportDataSource2.Value = this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.EntradasSalidasPersonalAreas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdsoftDataSet2
            // 
            this.bdsoftDataSet2.DataSetName = "bdsoftDataSet2";
            this.bdsoftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource
            // 
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource.DataMember = "Vw_Vw_ListaDeEntradaSalidaPersonalPorArea";
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource.DataSource = this.bdsoftDataSet2;
            // 
            // Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter
            // 
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_EntradaSalidaPersonalAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_EntradaSalidaPersonalAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada y salidas del personal por àreas";
            this.Load += new System.EventHandler(this.Frm_EntradaSalidaPersonalAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaBindingSource;
        private bdsoftDataSet2 bdsoftDataSet2;
        private bdsoftDataSet2TableAdapters.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter;
    }
}