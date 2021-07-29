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
    }
}
