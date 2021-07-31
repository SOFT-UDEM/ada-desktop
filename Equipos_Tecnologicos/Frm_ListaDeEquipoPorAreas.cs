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
    public partial class Frm_ListaDeEquipoPorAreas : Form
    {
        public Frm_ListaDeEquipoPorAreas()
        {
            InitializeComponent();
        }

        private void Frm_ListaDeEquipoPorAreas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet7.Vw_ListaDeEquiposPorAreas' Puede moverla o quitarla según sea necesario.
            this.Vw_ListaDeEquiposPorAreasTableAdapter.Fill(this.bdsoftDataSet7.Vw_ListaDeEquiposPorAreas);

            this.reportViewer1.RefreshReport();
        }
    }
}
