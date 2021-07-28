using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Equipos_Tecnologicos
{
    public partial class Frm_AddAreas : Form
    {
        public Frm_AddAreas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (bdsoftEntities db = new bdsoftEntities())
                {
                    Datos.Areas area = new Datos.Areas()
                    {
                        Nombre = txt_name.Text.Trim(),
                        Funcion = txt_func.Text.Trim(),
                        Observacion = txt_obs.Text.Trim()
                    };
                    db.Areas.Add(area);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Areas.ToList();
                    MessageBox.Show("Área guardarda correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_AddAreas_Load(object sender, EventArgs e)
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                dataGridView1.DataSource = db.Areas.ToList();
                dataGridView1.Columns["Empleados"].Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_func_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_obs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
