using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipos_Tecnologicos
{
    public partial class Frm_listaEmpleadosPorAreas : Form
    {
        public Frm_listaEmpleadosPorAreas()
        {
            InitializeComponent();
        }

        private void Frm_listaEmpleadosPorAreas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet4.Vw_ListaEmpleadosPorAreas' Puede moverla o quitarla según sea necesario.
            this.Vw_ListaEmpleadosPorAreasTableAdapter.Fill(this.bdsoftDataSet4.Vw_ListaEmpleadosPorAreas);

            this.reportViewer1.RefreshReport();
        }
    }
}
