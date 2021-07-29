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
    public partial class Frm_AddEquipments : Form
    {
        public Frm_AddEquipments()
        {
            InitializeComponent();
        }
        public Frm_AddEquipments(String loginUser)
        {
            InitializeComponent();
            currentUser(loginUser);
        }

        //public int IdUser;
        #region
        //Este método genera lista que contiene estados, para los equipos.
        private void listWithStatus()
        {
            List<string> list = new List<string>();
            list.Add("Buen estado");
            list.Add("Mal estado");
            comboEstado.DataSource = list;
        }
        //Este método genera una lista con los nombres de los empleados.
        private void listWithEmployed()
        {
            List<EmpleadosViewModel> lstEmployed = new List<EmpleadosViewModel>();

            using (bdsoftEntities database = new bdsoftEntities())
            {
                try
                {
                    lstEmployed = (from d in database.Empleados
                                   select new EmpleadosViewModel
                                   {
                                       cod = d.CodEmpleado,
                                       nombreCompleto = d.Apellido+" "+d.Nombre
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboEmpleado.DataSource = lstEmployed;
            comboEmpleado.ValueMember = "cod";
            comboEmpleado.DisplayMember = "nombreCompleto";
        }
        //Este método retorna el id del usuario con sesión iniciada
        private void currentUser(string userName)
        {

            using (bdsoftEntities database = new bdsoftEntities())
            {
                List<UsuariosViewModel> lstUser = new List<UsuariosViewModel>();

                try
                {
                    lstUser = (from d in database.Usuarios
                               where d.UserName == userName
                               select new UsuariosViewModel
                               {
                                   id = d.IdUsuario,
                                   nombre = d.UserName
                               }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboUsuario.DataSource = lstUser;
                comboUsuario.ValueMember = "id";
                comboUsuario.DisplayMember = "nombre";
            }
        }
        //Este método actualiza el datagridview
        private void updateDataInGrid()
        {
            using (bdsoftEntities database = new bdsoftEntities())
            {
                try
                {
                    dataGridView1.DataSource = database.EquiposTecnologicos.ToList();
                    dataGridView1.Columns["Empleados"].Visible = false;
                    dataGridView1.Columns["Usuarios"].Visible = false;
                    dataGridView1.Columns["CreadoPorUserName"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //Este método es para insertar en tabla equipostecnologicos
        private void createEquipments()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    EquiposTecnologicos equ = new EquiposTecnologicos()
                    {
                        Descripcion = txt_des.Text,
                        Modelo = txt_modelo.Text,
                        Marca = txt_marca.Text,
                        NumeroDeSerie = txt_serie.Text,
                        CodigoInterno = txt_codinter.Text,
                        Estado = comboEstado.Text,
                        CodEmpleado = Convert.ToInt32(comboEmpleado.SelectedValue),
                        ValorMonetario = Convert.ToInt32(numericValor.Value),
                        CreadoPorUserName = Convert.ToInt32(comboUsuario.SelectedValue),
                        Observacion = txt_obse.Text
                    };
                    db.EquiposTecnologicos.Add(equ);
                    db.SaveChanges();
                    updateDataInGrid();
                    MessageBox.Show("Equipo guardardo correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createEquipments();
        }

        private void Frm_AddEquipments_Load(object sender, EventArgs e)
        {
            listWithStatus();
            listWithEmployed();
            updateDataInGrid();
        }
    }
}
