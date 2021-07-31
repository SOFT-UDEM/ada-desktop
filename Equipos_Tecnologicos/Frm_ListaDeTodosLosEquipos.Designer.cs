
namespace Equipos_Tecnologicos
{
    partial class Frm_ListaDeTodosLosEquipos
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
            this.Vw_ListaDeTodosLosEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsoftDataSet6 = new Equipos_Tecnologicos.bdsoftDataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vw_ListaDeTodosLosEquiposTableAdapter = new Equipos_Tecnologicos.bdsoftDataSet6TableAdapters.Vw_ListaDeTodosLosEquiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeTodosLosEquiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // Vw_ListaDeTodosLosEquiposBindingSource
            // 
            this.Vw_ListaDeTodosLosEquiposBindingSource.DataMember = "Vw_ListaDeTodosLosEquipos";
            this.Vw_ListaDeTodosLosEquiposBindingSource.DataSource = this.bdsoftDataSet6;
            // 
            // bdsoftDataSet6
            // 
            this.bdsoftDataSet6.DataSetName = "bdsoftDataSet6";
            this.bdsoftDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1TodosLosEquipos";
            reportDataSource1.Value = this.Vw_ListaDeTodosLosEquiposBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Equipos_Tecnologicos.Reports.InventarioGeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Vw_ListaDeTodosLosEquiposTableAdapter
            // 
            this.Vw_ListaDeTodosLosEquiposTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ListaDeTodosLosEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ListaDeTodosLosEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario general del todos los equipos";
            this.Load += new System.EventHandler(this.Frm_ListaDeTodosLosEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ListaDeTodosLosEquiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoftDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_ListaDeTodosLosEquiposBindingSource;
        private bdsoftDataSet6 bdsoftDataSet6;
        private bdsoftDataSet6TableAdapters.Vw_ListaDeTodosLosEquiposTableAdapter Vw_ListaDeTodosLosEquiposTableAdapter;
    }
}