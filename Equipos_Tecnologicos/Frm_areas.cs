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
    public partial class Frm_areas : Form
    {
        public Frm_areas()
        {
            InitializeComponent();
        }

        private void Frm_areas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdsoftDataSet8.Areas' Puede moverla o quitarla según sea necesario.
            this.AreasTableAdapter.Fill(this.bdsoftDataSet8.Areas);

            this.reportViewer1.RefreshReport();
        }
    }
}
