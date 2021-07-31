
namespace Equipos_Tecnologicos
{
    partial class Frm_EntradaSalidaPersonal
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
            this.bdsoftDataSet1 = new Equipos_Tecnologicos.bdsoftDataSet1();
            this.Vw_ListaDeEntradaSalidaPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vw_ListaDeEntradaSalidaPersonalTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet1TableAdapters.Vw_ListaDeEntradaSalidaPersonalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeEntradaSalidaPersonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1EntradaSalidaPersonal";
            reportDataSource2.Value = this.Vw_ListaDeEntradaSalidaPersonalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.EntradasSalidasPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdsoftDataSet1
            // 
            this.bdsoftDataSet1.DataSetName = "bdsoftDataSet1";
            this.bdsoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_ListaDeEntradaSalidaPersonalBindingSource
            // 
            this.Vw_ListaDeEntradaSalidaPersonalBindingSource.DataMember = "Vw_ListaDeEntradaSalidaPersonal";
            this.Vw_ListaDeEntradaSalidaPersonalBindingSource.DataSource = this.bdsoftDataSet1;
            // 
            // Vw_ListaDeEntradaSalidaPersonalTableAdapter
            // 
            this.Vw_ListaDeEntradaSalidaPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_EntradaSalidaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_EntradaSalidaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada y salidas del personal";
            this.Load += new System.EventHandler(this.Frm_EntradaSalidaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeEntradaSalidaPersonalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_ListaDeEntradaSalidaPersonalBindingSource;
        private bdsoftDataSet1 bdsoftDataSet1;
        private bdsoftDataSet1TableAdapters.Vw_ListaDeEntradaSalidaPersonalTableAdapter Vw_ListaDeEntradaSalidaPersonalTableAdapter;
    }
}