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
    public partial class Frm_ListaDeTodosLosEquipos : Form
    {
        public Frm_ListaDeTodosLosEquipos()
        {
            InitializeComponent();
        }

        private void Frm_ListaDeTodosLosEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet6.Vw_ListaDeTodosLosEquipos' Puede moverla o quitarla según sea necesario.
            this.Vw_ListaDeTodosLosEquiposTableAdapter.Fill(this.bdsoftDataSet6.Vw_ListaDeTodosLosEquipos);

            this.reportViewer1.RefreshReport();
        }
    }
}
