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
using Datos.ViewModel;

namespace Equipos_Tecnologicos
{
    public partial class Frm_addemployes : Form
    {
        public Frm_addemployes()
        {
            InitializeComponent();
        }
        int IdEmpleado;
        private void updateDataInGrid()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    dataGridView1.DataSource = db.Empleados.ToList();
                    dataGridView1.Columns["Areas"].Visible = false;
                    dataGridView1.Columns["Asistencias"].Visible = false;
                    dataGridView1.Columns["EquiposTecnologicos"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //Este método genera una lista con las areas.
        private void listWithAreas()
        {
            List<AreasViewModel> lstAreas = new List<AreasViewModel>();

            using (bdsoftEntities database = new bdsoftEntities())
            {
                try
                {
                    lstAreas = (from d in database.Areas
                                select new AreasViewModel
                                {
                                    id = d.IdArea,
                                    nombre = d.Nombre
                                }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboAreas.DataSource = lstAreas;
            comboAreas.ValueMember = "id";
            comboAreas.DisplayMember = "nombre";
        }
        private void updateE()
        {
            using (bdsoftEntities bd = new bdsoftEntities())
            {
                try
                {
                    Empleados oE = bd.Empleados.Find(IdEmpleado);
                    if (oE != null)
                    {
                        oE.Nombre = txt_name.Text.Trim();
                        oE.Apellido = txt_apell.Text.Trim();
                        oE.Identificacion = txt_iden.Text.Trim();
                        oE.Cargo = txt_cargo.Text.Trim();
                        oE.IdArea = Convert.ToInt32(comboAreas.SelectedValue);
                        oE.Observacion = txt_obs.Text.Trim();
                        bd.SaveChanges();
                        MessageBox.Show("Persona actualizada correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataInGrid();
                        clean();
                    }else
                    {
                        MessageBox.Show("No hay registro para actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clean()
        {
            txt_name.Text = "";
            txt_apell.Text = "";
            txt_iden.Text = "";
            txt_cargo.Text = "";
            comboAreas.Text = "";
            txt_obs.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (bdsoftEntities db = new bdsoftEntities())
                {
                    Datos.Empleados emp = new Datos.Empleados()
                    {
                        Nombre = txt_name.Text,
                        Apellido = txt_apell.Text,
                        Identificacion = txt_iden.Text,
                        Cargo = txt_cargo.Text,
                        IdArea = Convert.ToInt32(comboAreas.SelectedValue),
                        Observacion = txt_obs.Text
                    };
                    db.Empleados.Add(emp);
                    db.SaveChanges();
                    updateDataInGrid();
                    clean();
                    MessageBox.Show("Empleado guardarda correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_addemployes_Load(object sender, EventArgs e)
        {
            updateDataInGrid();
            listWithAreas();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEmpleado = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (IdEmpleado > 0)
            {
                txt_name.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
                txt_apell.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                txt_iden.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
                txt_cargo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                txt_obs.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value);
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
            updateE();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
