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
    public partial class frmMenuInicial : Form
    {
        public frmMenuInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmReporte consulta = new frmReporte();
            consulta.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correa, Emiliano\n" +
                            "Ferrarese, Micaela\n" +
                            "Lazcano, Leonel\n" +
                            "Medina, Facundo\n" +
                            "Saurit, Lucas", "Acerca de nosotros...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente...", "En construcción...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
