using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace tpintegrador
{
    public partial class frmReporte : Form
    {
        AccesoDatos datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=DESKTOP-NC6ADKE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE");
        public frmReporte()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            reportClientes report = new reportClientes();
            string consultaSql = $"SELECT * FROM Clientes";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }

        private bool validarDni()
        {
            try
            {
                Int32.Parse(txtFiltroDni.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese sólo números.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtFiltroDni.Focus();
                txtFiltroDni.Clear();
                return false;
            }
            return true;
        }

        private bool validarId()
        {
            try
            {
                Int32.Parse(txtFiltroId.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese sólo números.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtFiltroId.Focus();
                txtFiltroId.Clear();
                return false;
            }
            return true;
        }

        private void btnFiltro_Click_1(object sender, EventArgs e)
        {
            reportClientes report = new reportClientes();

            string consultaSql = $"SELECT * FROM Clientes";

            if (txtFiltroNombre.Text != "")
            {
                consultaSql = $"SELECT * FROM Clientes WHERE nombre LIKE '%{txtFiltroNombre.Text}%'";
            }

            if (txtFiltroApellido.Text != "")
            {
                consultaSql = $"SELECT * FROM Clientes WHERE apellido LIKE '%{txtFiltroApellido.Text}%'";
            }

            if (txtFiltroDni.Text != "" && validarDni())
            {
                consultaSql = $"SELECT * FROM Clientes WHERE dni = {Convert.ToInt32(txtFiltroDni.Text)}";
            }

            if (txtFiltroId.Text != "" && validarId())
            {
                consultaSql = $"SELECT * FROM Clientes WHERE id_cliente = {Convert.ToInt32(txtFiltroId.Text)}";
            }

            report.SetDataSource(datos.consultarDB(consultaSql));
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }

        //todo lo siguiente se puede resolver con un metodo, queda pendiente
        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                txtFiltroNombre.Enabled = true;
                chkApellido.Enabled = false;
                chkDni.Enabled = false;
                chkId.Enabled = false;
            }
            else
            {
                txtFiltroId.Enabled = false;
                txtFiltroNombre.Enabled = false;
                txtFiltroApellido.Enabled = false;
                txtFiltroDni.Enabled = false;
                chkApellido.Enabled = true;
                chkDni.Enabled = true;
                chkId.Enabled = true;
            }
            
        }

        private void chkApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApellido.Checked)
            {
                txtFiltroApellido.Enabled = true;
                chkNombre.Enabled = false;
                chkDni.Enabled = false;
                chkId.Enabled = false;
            }
            else
            {
                txtFiltroId.Enabled = false;
                txtFiltroNombre.Enabled = false;
                txtFiltroApellido.Enabled = false;
                txtFiltroDni.Enabled = false;
                chkNombre.Enabled = true;
                chkDni.Enabled = true;
                chkId.Enabled = true;
            }
        }

        private void chkDni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDni.Checked)
            {
                txtFiltroDni.Enabled = true;
                chkApellido.Enabled = false;
                chkNombre.Enabled = false;
                chkId.Enabled = false;
            }
            else
            {
                txtFiltroId.Enabled = false;
                txtFiltroNombre.Enabled = false;
                txtFiltroApellido.Enabled = false;
                txtFiltroDni.Enabled = false;
                chkApellido.Enabled = true;
                chkNombre.Enabled = true;
                chkId.Enabled = true;
            }
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkId.Checked)
            {
                txtFiltroId.Enabled = true;
                chkApellido.Enabled = false;
                chkNombre.Enabled = false;
                chkDni.Enabled = false;
            }
            else
            {
                txtFiltroId.Enabled = false;
                txtFiltroNombre.Enabled = false;
                txtFiltroApellido.Enabled = false;
                txtFiltroDni.Enabled = false;
                chkApellido.Enabled = true;
                chkNombre.Enabled = true;
                chkDni.Enabled = true;
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            txtFiltroId.Enabled = false;
            txtFiltroNombre.Enabled = false;
            txtFiltroApellido.Enabled = false;
            txtFiltroDni.Enabled = false;
        }
    }
}
