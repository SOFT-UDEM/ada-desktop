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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (bdsoftEntities db = new bdsoftEntities())
                {
                    var loginUser = txt_user.Text.ToString();
                    var loginPass = txt_pass.Text.ToString();

                    //string userDefault = "user";
                    //string passwordDesfault = "1234";
                    
                    //if (loginUser == userDefault && loginPass == passwordDesfault)
                    //{
                    //    Frm_Dashboard das = new Frm_Dashboard();
                    //    das.Show();
                    //}

                    //Encriptación de contraseña
                    loginPass = Encrypt.GetSHA256(loginPass);

                    var user = db.Usuarios.Where(x => x.UserName == loginUser).Where(c => c.Password == loginPass).FirstOrDefault();

                    if (user != null)
                    {
<<<<<<< HEAD
                        Frm_Dashboard das = new Frm_Dashboard();
                        this.Hide();
                        das.Show();

=======
                        this.Hide();
                        Frm_Dashboard dash = new Frm_Dashboard(loginUser);
                        dash.FormClosed += (s, args) => this.Close();
                        dash.Show();
>>>>>>> 5cb122aed3a42961bfa7e7565cf80eb0ccaee9ce
                    }
                    else
                    {
                        MessageBox.Show("Las credenciales son incorrectas " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (bdsoftEntities db = new bdsoftEntities())
                {
                    var loginUser = txt_user.Text.ToString();
                    var loginPass = txt_pass.Text.ToString();

                    string userDefault = "user";
                    string passwordDesfault = "1234";

                    //var user = db.Usuarios.Where(x => x.UserName == loginUser).Where(c => c.Password == loginPass).FirstOrDefault();

                    // if (user != null)
                    // {
                    //     Frm_Dashboad dash = new Frm_Dashboad();
                    //     dash.Show();
                    // }

                    if (loginUser == userDefault && loginPass == passwordDesfault)
                    {
                        Frm_Dashboard das = new Frm_Dashboard();
                        this.Hide();
                        das.Show();

                    }
                    else
                    {
                        MessageBox.Show("Las credenciales son incorrectas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
