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
    public partial class Frm_EntradaSalidaPersonal : Form
    {
        public Frm_EntradaSalidaPersonal()
        {
            InitializeComponent();
        }

        private void Frm_EntradaSalidaPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet1.Vw_ListaDeEntradaSalidaPersonal' Puede moverla o quitarla según sea necesario.
            this.Vw_ListaDeEntradaSalidaPersonalTableAdapter.Fill(this.bdsoftDataSet1.Vw_ListaDeEntradaSalidaPersonal);

            this.reportViewer1.RefreshReport();
        }
    }
}
