using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace ada_desktop
{
    public partial class FrmAdministrarUsuarios : Form
    {
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        bool listoParaGuardar = false;
        int idUsuario = 0;

        #region
        private void listWithAccessRoles()
        {
            List<string> listWithRoles = new List<string>();
            listWithRoles.Add("Admin");
            listWithRoles.Add("User");
            comboBoxRoles.DataSource = listWithRoles;
        }
        private void updateDataInGrid()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    dtg.DataSource = db.Usuarios.ToList();
                    dtg.Columns["EquiposTecnologicos"].Visible = false;
                    dtg.Columns["Password"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void createUsers()
        {           
           using (bdsoftEntities db = new bdsoftEntities())
           {
                try
                {
                    Datos.Usuarios oUser = new Datos.Usuarios()
                    {
                        Nombre = txtNombres.Text.Trim(),
                        Apellido = txtApellidos.Text.Trim(),
                        Cargo = txtCargo.Text.Trim(),
                        RolDeAcceso = comboBoxRoles.Text.Trim(),
                        UserName = txtUsuario.Text.Trim(),
                        //Encriptamos contraseña
                        Password = Encrypt.GetSHA256(txtPassword.Text),
                        Observacion = txtObservacion.Text.Trim()
                    };
                    db.Usuarios.Add(oUser);
                    db.SaveChanges();
                    updateDataInGrid();
                    MessageBox.Show("Usuario guardardo correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
           }  
        }
        private void updateUsers()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
              try
                {
                    Usuarios oUser = db.Usuarios.Find(idUsuario);
                    if (oUser != null)
                    {
                        oUser.Nombre = txtNombres.Text.Trim();
                        oUser.Apellido = txtApellidos.Text.Trim();
                        oUser.Cargo = txtCargo.Text.Trim();
                        oUser.RolDeAcceso = comboBoxRoles.Text.Trim();
                        oUser.UserName = txtUsuario.Text.Trim();
                        if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
                        {
                            //Encriptamos contraseña antes de actualizar
                            oUser.Password = Encrypt.GetSHA256(txtPassword.Text);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Usuario actualizado correctamente","Felicitaciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        updateDataInGrid();
                        cleanForm();
                        btnGuardar.Text = "Guardar";
                        btnEditar.Visible = true;
                        btnCancelar.Visible = false;
                        idUsuario = 0;
                    }
                    else
                    {
                        MessageBox.Show("No hay registro para actualizar","Atención",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void validarCamposVacios() {
            if (txtNombres.Text.Trim().Length == 0)
            {
                MessageBox.Show("Es requerido que escribas el nombre","Nombre es requerido.",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                txtNombres.Focus();
                listoParaGuardar = false;
            }
            else if (txtApellidos.Text.Trim().Length == 0) {
                MessageBox.Show("Es requerido que escribas el apellido", "Apellido es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtApellidos.Focus();
                listoParaGuardar = false;
            }
            else if (txtCargo.Text.Trim().Length == 0) {
                MessageBox.Show("Es requerido que escribas el cargo", "Cargo es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtCargo.Focus();
                listoParaGuardar = false;
            }
            else if (comboBoxRoles.Text.Trim().Length == 0) {
                MessageBox.Show("Es requerido el rol de acceso", "Rol de acceso es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                comboBoxRoles.Focus();
                listoParaGuardar = false;
            }
            else if (txtUsuario.Text.Trim().Length == 0) {
                MessageBox.Show("Es requerido que escribas el usuario", "Usuario es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUsuario.Focus();
                listoParaGuardar = false;
            }
            else if(txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Es requerido que escribas la contraseña", "Contraseña es requerida.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtPassword.Focus();
                listoParaGuardar = false;
            } else
            {
                listoParaGuardar = true;
            }
        }
        private void cleanForm()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCargo.Text = string.Empty;
            comboBoxRoles.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtObservacion.Text = string.Empty;

        }
        #endregion                    

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idUsuario > 0)            
                updateUsers();            
            else
            {
                validarCamposVacios();
                if (listoParaGuardar == true)
                    createUsers();
            }
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            listWithAccessRoles();
            //Actualizar datos en el DataGrid
            updateDataInGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idUsuario = int.Parse(dtg.Rows[dtg.CurrentRow.Index].Cells[0].Value.ToString());
            if(idUsuario > 0)
            {
                txtNombres.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[1].Value.ToString();
                txtApellidos.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[2].Value.ToString();
                txtCargo.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[3].Value.ToString();
                comboBoxRoles.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[4].Value.ToString();
                txtUsuario.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[5].Value.ToString();
                txtObservacion.Text = dtg.Rows[dtg.CurrentRow.Index].Cells[7].Value.ToString();
                btnGuardar.Text = "Actualizar";
                btnCancelar.Visible = true;
                btnEditar.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cleanForm();
            idUsuario = 0;
            if(idUsuario <= 0)
            {
                btnGuardar.Text = "Guardar";
                btnCancelar.Visible = false;
                btnEditar.Visible = true;
            }
            
        }
    }
}
