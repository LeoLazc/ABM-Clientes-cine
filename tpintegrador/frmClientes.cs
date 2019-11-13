using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpintegrador
{
    public partial class frmClientes : Form
    {
        AccesoDatos datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=DESKTOP-NC6ADKE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINE");
        List<Cliente> lsCliente = new List<Cliente>();
        bool nuevo = false;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarCombo(cbNacionalidad, "Paises");
            cargarLista("Clientes");
            habilitar(false);
        }

        private void cargarLista(string nombreTabla)
        {
            lsCliente.Clear();
            datos.leerTabla(nombreTabla);
            while (datos.pDr.Read())
            {
                Cliente cl = new Cliente();
                if (!datos.pDr.IsDBNull(0))
                    cl.pId = datos.pDr.GetInt32(0);
                if (!datos.pDr.IsDBNull(1))
                    cl.pNombre = datos.pDr.GetString(1);
                if (!datos.pDr.IsDBNull(2))
                    cl.pApellido = datos.pDr.GetString(2);
                if (!datos.pDr.IsDBNull(3))
                    cl.pDni = datos.pDr.GetInt32(3);
                if (!datos.pDr.IsDBNull(4))
                    cl.pFechaNac = datos.pDr.GetDateTime(4);
                if (!datos.pDr.IsDBNull(5))
                    cl.pDireccion = datos.pDr.GetString(5);
                if (!datos.pDr.IsDBNull(6))
                    cl.pAltura = datos.pDr.GetInt32(6);
                if (!datos.pDr.IsDBNull(7))
                    cl.pTelefono = datos.pDr.GetInt32(7);
                if (!datos.pDr.IsDBNull(8))
                    cl.pEmail = datos.pDr.GetString(8);
                if (!datos.pDr.IsDBNull(9))
                    cl.pNacionalidad = datos.pDr.GetInt32(9);
                if (!datos.pDr.IsDBNull(10))
                    cl.pFechaAlta = datos.pDr.GetDateTime(10);

                lsCliente.Add(cl);
            }
            datos.pDr.Close();
            datos.desconectar();
            lstClientes.Items.Clear();
            for (int i = 0; i < lsCliente.Count; i++)
            {
                lstClientes.Items.Add(lsCliente[i].ToString());
            }
            lstClientes.SelectedIndex = lstClientes.Items.Count - 1;

        }
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void habilitar(bool x)
        {
            txtId.Enabled = x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            dtpFecNac.Enabled = x;
            txtDni.Enabled = x;
            txtCalle.Enabled = x;
            txtNumero.Enabled = x;
            txtTelefono.Enabled = x;
            txtEmail.Enabled = x;
            dtpFecAlta.Enabled = x;
            cbNacionalidad.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;

            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            lstClientes.Enabled = !x;
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text="";
            txtApellido.Text = "";
            txtDni.Text = "";
            dtpFecNac.Value = DateTime.Today;
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtpFecAlta.Value = DateTime.Today;
            cbNacionalidad.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            habilitar(true);
            txtId.Enabled = false;
            limpiar();
            txtNombre.Focus();
        }

        private bool existe(int pk)
        {
            for (int i = 0; i < lstClientes.Items.Count; i++)
                if (lsCliente[i].pId == pk)
                    return true;
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            nuevo = false;
            cargarCampos(lstClientes.SelectedIndex);
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstClientes.SelectedIndex);
        }

        private void cargarCampos(int posicion)
        {
            txtId.Text = lsCliente[posicion].pId.ToString();
            txtNombre.Text = lsCliente[posicion].pNombre;
            txtApellido.Text = lsCliente[posicion].pApellido;
            txtDni.Text = lsCliente[posicion].pDni.ToString();
            txtCalle.Text = lsCliente[posicion].pDireccion;
            txtNumero.Text = lsCliente[posicion].pAltura.ToString();
            txtTelefono.Text = lsCliente[posicion].pTelefono.ToString();
            txtEmail.Text = lsCliente[posicion].pEmail;
            cbNacionalidad.SelectedValue = lsCliente[posicion].pNacionalidad;
            dtpFecNac.Value = lsCliente[posicion].pFechaNac;
            dtpFecAlta.Value = lsCliente[posicion].pFechaAlta;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtId.Enabled = false;
            nuevo = false;
            txtId.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Cliente cl = new Cliente();
                //cl.pId = Convert.ToInt32(txtId.Text);
                cl.pNombre = txtNombre.Text;
                cl.pApellido = txtApellido.Text;
                cl.pDni = Convert.ToInt32(txtDni.Text);
                cl.pDireccion = txtCalle.Text;
                cl.pAltura = Convert.ToInt32(txtNumero.Text);
                cl.pTelefono = Convert.ToInt32(txtTelefono.Text);
                cl.pEmail = txtEmail.Text;
                cl.pFechaNac = dtpFecNac.Value;
                cl.pFechaAlta = dtpFecAlta.Value;
                cl.pNacionalidad = Convert.ToInt32(cbNacionalidad.SelectedValue);

                string sql;

                if (nuevo)
                    if (!existe(cl.pId))
                    {
                        sql = $"INSERT INTO Clientes(nombre, apellido, dni, fecha_nac, calle_direccion, nro_direccion, nro_telefono, email, nacionalidad, fecha_alta) VALUES(" +
                            $"'{cl.pNombre}', " +
                            $"'{cl.pApellido}', " +
                            $"{cl.pDni}, " +
                            $"'{cl.pFechaNac.ToShortDateString()}', " +
                            $"'{cl.pDireccion}', " +
                            $"{cl.pAltura}, " +
                            $"{cl.pTelefono}, " +
                            $"'{cl.pEmail}', " +
                            $"{cl.pNacionalidad}, " +
                            $"'{cl.pFechaAlta.ToShortDateString()}')";
                        datos.actualizar(sql);
                        lstClientes.Items.Clear();
                        cargarLista("Clientes");
                    }
                    //else
                    //{
                    //    MessageBox.Show("Este cliente ya se encuentra registrado...");
                    //    habilitar(true);
                    //    txtId.Focus();
                    //}
                        
                else
                {
                    sql = $"UPDATE Clientes SET nombre = '{cl.pNombre}', " +
                                              $"apellido = '{cl.pApellido}', " +
                                              $"dni = {cl.pDni}, " +
                                              $"fecha_nac = '{cl.pFechaNac.ToShortDateString()}', " +
                                              $"calle_direccion = '{cl.pDireccion}', " +
                                              $"nro_direccion = {cl.pAltura}, " +
                                              $"nro_telefono = {cl.pTelefono}, " +
                                              $"email = '{cl.pEmail}', " +
                                              $"nacionalidad = {cl.pNacionalidad}, " +
                                              $"fecha_alta = '{cl.pFechaAlta.ToShortDateString()}' " +
                                              $"WHERE id_cliente = {cl.pId}";
                    datos.actualizar(sql);
                    lstClientes.Items.Clear();
                    cargarLista("Clientes");
                    lstClientes.SelectedIndex = cl.pId -1;
                }
                habilitar(false);
                nuevo = false;
            }
        }

        private bool validar()
        {
            //if(txtId.Text=="")
            //{
            //    MessageBox.Show("Debe completar el ID de cliente...");
            //    txtId.Focus();
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        Int32.Parse(txtId.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Coloque sólo números.",
            //            "Error",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);
            //        txtId.Focus();
            //        return false;
            //    }
            //}

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar el nombre del cliente...");
                txtNombre.Focus();
                return false;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar el apellido del cliente...");
                txtApellido.Focus();
                return false;
            }

            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe completar el DNI del cliente...");
                txtDni.Focus();
                return false;
            }
            else
            {
                try
                {
                    Int32.Parse(txtDni.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese sólo números.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtDni.Focus();
                    return false;
                }
            }

            if (dtpFecNac.Value >DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser posterior a la fecha actual...");
                dtpFecNac.Focus();
                return false;
            }

            if (txtCalle.Text == "")
            {
                MessageBox.Show("Debe completar la calle...");
                txtCalle.Focus();
                return false;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Debe completar el número de la calle...");
                txtNumero.Focus();
                return false;
            }
            else
            {
                try
                {
                    Int32.Parse(txtNumero.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese sólo números.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNumero.Focus();
                    return false;
                }
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe completar el número de telefono...");
                txtTelefono.Focus();
                return false;
            }
            else
            {
                try
                {
                    Int32.Parse(txtTelefono.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese sólo números.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtTelefono.Focus();
                    return false;
                }
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar el E-mail...");
                txtEmail.Focus();
                return false;
            }

            if (dtpFecAlta.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de alta no puede ser posterior a la fecha actual...");
                dtpFecAlta.Focus();
                return false;
            }

            if (cbNacionalidad.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una nacionalidad...");
                cbNacionalidad.Focus();
                return false;
            }
            return true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el cliente " + lsCliente[lstClientes.SelectedIndex].pNombre + " " +
                lsCliente[lstClientes.SelectedIndex].pApellido + "?"
                , "Borrar"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                string sql = "Delete from Clientes where id_cliente=" + lsCliente[lstClientes.SelectedIndex].pId;
                datos.actualizar(sql);
                cargarLista("Clientes");
            }
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea volver al menú principal? Algunos datos se pueden perder si cierra la ventana.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
