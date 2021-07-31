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
    public partial class Frm_AsistenciaEmpleados : Form
    {
        public Frm_AsistenciaEmpleados()
        {
            InitializeComponent();
        }
        #region
        //Este método actualiza el datagridview
        private void updateDataInGrid()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                try
                {
                    dtgDetalle.DataSource = db.DetalleDeAsistencias.Select(d => new { d.IdAsistencia, d.FechaHoraEntrada, d.FechaHoraSalida, d.Observacion }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
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
        // Este método valida que no haya campos vacios.
        private bool validateEmptyFields()
        {
            if (comboEmpleado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Falta seleccionar empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEmpleado.Focus();
                return false;
            }
            else
                return true;
        }
        //Este método limpia el formulario
        private void clean()
        {
            comboEmpleado.Text = string.Empty;
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            txtObs.Text = string.Empty;
        }
        //Este método guarda una nueva asitencia.
        private void createAssistance()
        {
            using (bdsoftEntities db = new bdsoftEntities())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Asistencias oAs = new Asistencias();
                        oAs.CodEmpleado = Convert.ToInt32(comboEmpleado.SelectedValue);
                        db.Asistencias.Add(oAs);
                        db.SaveChanges();

                        DetalleDeAsistencias oDetalle = new DetalleDeAsistencias();
                        oDetalle.IdAsistencia = oAs.IdAsistencia;
                        oDetalle.FechaHoraEntrada = dtpEntrada.Value;
                        oDetalle.FechaHoraSalida = dtpSalida.Value;
                        oDetalle.Observacion = txtObs.Text.Trim();
                        db.DetalleDeAsistencias.Add(oDetalle);
                        db.SaveChanges();

                        dbContextTransaction.Commit();
                        updateDataInGrid();
                        MessageBox.Show("Asistencia creada correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dbContextTransaction.Rollback();
                    }
                }
            }
        }
        #endregion

        private void Frm_AsistenciaEmpleados_Load(object sender, EventArgs e)
        {
            listWithEmployed();
            updateDataInGrid();
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Este método debe retornar true, para que se ejecute
            //el método de guardar.
            if (validateEmptyFields())
                createAssistance();
        }
    }
}
