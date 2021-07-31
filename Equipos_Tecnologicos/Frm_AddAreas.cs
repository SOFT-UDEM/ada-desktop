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

        int IdArea;
        private void clean()
        {
            txt_name.Text = "";
            txt_func.Text = "";
            txt_obs.Text = "";
        }
        private void updateDataInGrid()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                dataGridView1.DataSource = db.Areas.ToList();
                dataGridView1.Columns["Empleados"].Visible = false;
            }
        }
        private void updateArea()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    Areas oA = db.Areas.Find(IdArea);
                    if (oA != null)
                    {
                        oA.Nombre = txt_name.Text.Trim();
                        oA.Funcion = txt_func.Text.Trim();
                        oA.Observacion = txt_obs.Text.Trim();
                        db.SaveChanges();
                        MessageBox.Show("Area actualizada correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataInGrid();
                        clean();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    updateDataInGrid();
                    clean();
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
            updateDataInGrid();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdArea = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (IdArea > 0)
            {
                txt_name.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txt_func.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txt_obs.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clean();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            updateArea();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
