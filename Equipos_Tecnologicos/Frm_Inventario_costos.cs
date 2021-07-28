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
    public partial class Frm_Inventario_costos : Form
    {
        public Frm_Inventario_costos()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_costos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet3.Vw_ListaDeInventarioCostos' Puede moverla o quitarla según sea necesario.
            this.Vw_ListaDeInventarioCostosTableAdapter.Fill(this.bdsoftDataSet3.Vw_ListaDeInventarioCostos);

            this.reportViewer1.RefreshReport();
        }
    }
}
