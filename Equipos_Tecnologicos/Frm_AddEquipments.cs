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
    public partial class Frm_AddEquipments : Form
    {
        public Frm_AddEquipments()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (bdsoftEntities db = new bdsoftEntities())
                {
                    Datos.EquiposTecnologicos equ = new Datos.EquiposTecnologicos()
                    {
                       Descripcion = txt_des.Text,
                       Modelo = txt_modelo.Text,
                       Marca = txt_marca.Text,
                       NumeroDeSerie = txt_serie.Text,
                       CodigoInterno = txt_codinter.Text,
                       Estado = txt_estado.Text,
                       CodEmpleado = Convert.ToInt32( txt_codemple.Text),
                       ValorMonetario = Convert.ToInt32( txt_valorMone.Text),
                       CreadoPorUserName = Convert.ToInt32( txt_creado.Text),
                       Observacion = txt_obse.Text

                    };
                    db.EquiposTecnologicos.Add(equ);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.EquiposTecnologicos.ToList();
                    MessageBox.Show("Equipo guardardo correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_AddEquipments_Load(object sender, EventArgs e)
        {
            using (var db = new bdsoftEntities())
            {
                dataGridView1.DataSource = db.EquiposTecnologicos.ToList();
            }
        }
    }
}
