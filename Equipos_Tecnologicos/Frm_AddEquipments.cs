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
        int IdEquipo;
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
                                       nombreCompleto = d.Apellido + " " + d.Nombre
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
        //Este método es para validar campos vacios
        private bool validateEmptyFields()
        {
            if (txt_des.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Es necesario escribir una descripción", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_des.Focus();
                return false;
            }
            else if (txt_codinter.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Es necesario escribir un código interno", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_codinter.Focus();
                return false;
            }
            else if (comboEstado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Es necesario seleccionar un estado", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return false;
            }
            else if (comboEmpleado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Es necesario seleccionar un empleado", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEmpleado.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Este método es para limpiar el  formulario
        private void clean()
        {
            txt_des.Text = string.Empty;
            txt_marca.Text = string.Empty;
            txt_modelo.Text = string.Empty;
            txt_serie.Text = string.Empty;
            txt_codinter.Text = string.Empty;
            comboEstado.Text = string.Empty;
            comboEmpleado.Text = string.Empty;
            numericValor.Value = 0;
            txt_obse.Text = string.Empty;
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
                    clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Este método es para actualizar en tabla equipostecnologicos
        private void updateEquipments()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    EquiposTecnologicos oEqu = db.EquiposTecnologicos.Find(IdEquipo);
                    if (oEqu != null)
                    {
                        oEqu.Descripcion = txt_des.Text;
                        oEqu.Modelo = txt_modelo.Text;
                        oEqu.Marca = txt_marca.Text;
                        oEqu.NumeroDeSerie = txt_serie.Text;
                        oEqu.CodigoInterno = txt_codinter.Text;
                        oEqu.Estado = comboEstado.Text;
                        oEqu.CodEmpleado = Convert.ToInt32(comboEmpleado.SelectedValue);
                        oEqu.ValorMonetario = Convert.ToInt32(numericValor.Value);
                        oEqu.CreadoPorUserName = Convert.ToInt32(comboUsuario.SelectedValue);
                        oEqu.Observacion = txt_obse.Text;
                        db.SaveChanges();
                        MessageBox.Show("Equipo actualizado correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataInGrid();
                        clean();
                    }
                    else
                    {
                        MessageBox.Show("No hay registro para actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Este método es para eliminar en tabla equipostecnologicos
        private void deleteEquipments(int id)
        {
            using (bdsoftEntities database = new bdsoftEntities())
            {
                try
                {
                    EquiposTecnologicos oEqu = database.EquiposTecnologicos.Find(id);
                    database.EquiposTecnologicos.Remove(oEqu);
                    database.SaveChanges();
                    MessageBox.Show("Equipo eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataInGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void Frm_AddEquipments_Load(object sender, EventArgs e)
        {
            listWithStatus();
            listWithEmployed();
            updateDataInGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Frm_Report_Teams Rt = new Frm_Report_Teams();
            //Rt.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateEmptyFields() == true)
                createEquipments();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IdEquipo = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (IdEquipo > 0)
            {
                txt_des.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txt_modelo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                txt_marca.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
                txt_serie.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                txt_codinter.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
                comboEstado.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                numericValor.Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
                txt_obse.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateEmptyFields() == true)
            {
                updateEquipments();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteEquipments(IdEquipo);
            clean();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
