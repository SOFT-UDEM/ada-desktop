using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipos_Tecnologicos;

namespace ada_desktop
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios user = new FrmAdministrarUsuarios();
            user.MdiParent = this;
            user.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_AddAreas user = new Frm_AddAreas();
            user.MdiParent = this;
            user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_AddEquipments user = new Frm_AddEquipments();
            user.MdiParent = this;
            user.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            Frm_addemployes user = new Frm_addemployes();
            user.MdiParent = this;
            user.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Frm_Reports reports = new Frm_Reports();
            reports.MdiParent = this;
            reports.Show();
        }
    }
}
