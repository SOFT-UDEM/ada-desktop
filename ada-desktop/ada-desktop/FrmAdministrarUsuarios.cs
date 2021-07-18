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

namespace ada_desktop
{
    public partial class FrmAdministrarUsuarios : Form
    {
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        bool listoParaGuardar = false;

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
            else if (txtRolAcceso.Text.Trim().Length == 0) {
                MessageBox.Show("Es requerido el rol de acceso", "Rol de acceso es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtRolAcceso.Focus();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validarCamposVacios();
            if (listoParaGuardar == true)
            {
                try
                {
                    using (bdsoftEntities db = new bdsoftEntities())
                    {
                        Datos.Usuarios oUser = new Datos.Usuarios() {
                            Nombre = txtNombres.Text.Trim(),
                            Apellido = txtApellidos.Text.Trim(),
                            Cargo = txtCargo.Text.Trim(),
                            RolDeAcceso = txtRolAcceso.Text.Trim(),
                            UserName = txtUsuario.Text.Trim(),
                            //Encriptamos contraseña
                            Password = Encrypt.GetSHA256(txtPassword.Text),
                            Observacion = txtObservacion.Text.Trim()
                        };
                        db.Usuarios.Add(oUser);
                        db.SaveChanges();
                        dtg.DataSource = db.Usuarios.ToList();
                        MessageBox.Show("Usuario guardardo correctamente", "Felicitaciones", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {

            using (bdsoftEntities db = new bdsoftEntities())
            {

                dtg.DataSource = db.Usuarios.ToList();
               
            }

        }
    }
}
