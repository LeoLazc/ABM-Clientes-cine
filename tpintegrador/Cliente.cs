using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpintegrador
{
    class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaNac;
        private string direccion;
        private int telefono;
        private string email;
        private int nacionalidad;
        private DateTime fechaAlta;
        private int altura;

        public int pAltura
        {
            get { return altura; }
            set { altura = value; }
        }


        public DateTime pFechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        public int pNacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string pEmail
        {
            get { return email; }
            set { email = value; }
        }
        public int pTelefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string pDireccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public DateTime pFechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public int pDni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string pApellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int pId
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"ID: {id} - Cliente: {nombre} {apellido} - DNI: {dni}";
        }
    }
}
