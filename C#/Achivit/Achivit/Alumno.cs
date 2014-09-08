using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achivit
{
    class Alumno
    {
        #region Variables
        private string _nombre;
        private string _cuenta;
        private string _email;
        private int _edad;
        #endregion

        #region Constructores
        public Alumno()
        {
            _nombre = "";
            _email = "";
            _cuenta = "";
            _edad = 0;
        }

        public Alumno(string nombre, string cuenta, string email, int edad)
        {
            _nombre = nombre;
            _email = email;
            _cuenta = cuenta;
            _edad = edad;
        }
        #endregion

        #region Get/Set
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion

        public string toString()
        {
            return "Nombre: " + Nombre + " con cuenta: " + Cuenta + " y correo: " + Email + " tiene: " + Edad + " años.";
        }
    }
}
