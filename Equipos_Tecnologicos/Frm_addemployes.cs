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
    public partial class Frm_addemployes : Form
    {
        public Frm_addemployes()
        {
            InitializeComponent();
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
                        IdArea = Convert.ToInt32(txt_area.Text),
                        Observacion = txt_obs.Text
                    };
                    db.Empleados.Add(emp);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Empleados.ToList();
                    MessageBox.Show("Empleado guardarda correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
