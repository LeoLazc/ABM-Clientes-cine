using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpintegrador
{
    class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fecNac;
        private string nombreDireccion;
        private int nroDireccion;
        private string nroTelefono;
        private string email;
        private string nacionalidad;
        private DateTime fechaAlta;

        public int pIdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public int pDni
        {
            set { dni = value; }
            get { return dni; }
        }

        public DateTime pFecNac
        {
            set { fecNac = value; }
            get { return fecNac; }
        }

        public string pNombreDireccion
        {
            set { nombreDireccion = value; }
            get { return nombreDireccion; }
        }

        public int pNroDireccion
        {
            set { nroDireccion = value; }
            get { return nroDireccion; }
        }

        public string pNroTelefono
        {
            set { nroTelefono = value; }
            get { return nroTelefono; }
        }

        public string pEmail
        {
            set { email = value; }
            get { return email; }
        }

        public string pNacionalidad
        {
            set { nacionalidad = value; }
            get { return nacionalidad; }
        }

        public DateTime pFecAlta
        {
            set { fechaAlta = value; }
            get { return fechaAlta; }
        }

        override public string ToString()
        {
            return nombre + " - " + apellido;
        }
    }
}
