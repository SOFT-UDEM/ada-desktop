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
        Boolean statePanelReports = false;
        public Frm_Dashboard()
        {
            InitializeComponent();
        }
        public Frm_Dashboard(String loginUser)
        {
            InitializeComponent();
            lblUser.Text = loginUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios user = new FrmAdministrarUsuarios();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_AddAreas user = new Frm_AddAreas();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_AddEquipments user = new Frm_AddEquipments();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            Frm_addemployes user = new Frm_addemployes();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login login = new Frm_Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Frm_Reports reports = new Frm_Reports();
            reports.MdiParent = this;
            reports.Show();
            pa_reports.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios user = new FrmAdministrarUsuarios();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Frm_AddAreas user = new Frm_AddAreas();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_AddEquipments user = new Frm_AddEquipments();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_addemployes user = new Frm_addemployes();
            user.MdiParent = this;
            user.Show();
            pa_reports.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //pa_reports.Visible = false;
            //statePanelReports = true;


            if (pa_reports.Visible)
            {
                pa_reports.Visible = false;
            }
            else
            {
                pa_reports.Visible = true;
            }
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            pa_reports.Visible = false;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Frm_EntradaSalidaPersonal asistenciaPersonal = new Frm_EntradaSalidaPersonal();
            asistenciaPersonal.MdiParent = this;
            asistenciaPersonal.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Frm_EntradaSalidaPersonalAreas asistenciaPorAreas = new Frm_EntradaSalidaPersonalAreas();
            asistenciaPorAreas.MdiParent = this;
            asistenciaPorAreas.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Frm_Inventario_costos inventarioCostos = new Frm_Inventario_costos();
            inventarioCostos.MdiParent = this;
            inventarioCostos.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Frm_listaEmpleadosPorAreas em = new Frm_listaEmpleadosPorAreas();
            em.MdiParent = this;
            em.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Frm_ListaDeTodosLosEquipos todos = new Frm_ListaDeTodosLosEquipos();
            todos.MdiParent = this;
            todos.Show();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            Frm_ListaDeEquipoPorAreas epa = new Frm_ListaDeEquipoPorAreas();
            epa.MdiParent = this;
            epa.Show();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            Frm_areas areas = new Frm_areas();
            areas.MdiParent = this;
            areas.Show();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            Frm_AsistenciaEmpleados asistencia = new Frm_AsistenciaEmpleados();
            asistencia.MdiParent = this;
            asistencia.Show();
        }
    }
}
