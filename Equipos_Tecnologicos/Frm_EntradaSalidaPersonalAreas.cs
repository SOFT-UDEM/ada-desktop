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
    public partial class Frm_EntradaSalidaPersonalAreas : Form
    {
        public Frm_EntradaSalidaPersonalAreas()
        {
            InitializeComponent();
        }

        private void Frm_EntradaSalidaPersonalAreas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet2.Vw_Vw_ListaDeEntradaSalidaPersonalPorArea' Puede moverla o quitarla según sea necesario.
            this.Vw_Vw_ListaDeEntradaSalidaPersonalPorAreaTableAdapter.Fill(this.bdsoftDataSet2.Vw_Vw_ListaDeEntradaSalidaPersonalPorArea);

            this.reportViewer1.RefreshReport();
        }
    }
}
