using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Achivit
{
    class Alumno
    {
        #region Variables
        private string _nombre;
        private string _cuenta;
        private string _email;
        private int _edad;
        Regex _nombres = new Regex(@"^[A-Za-z][A-Za-zñ,\s-,\s(,\s,\s.)]+$");
        Regex _numeros = new Regex("^[0-9]+$");
        Regex _emailR = new Regex(@"^[a-z0-9_.]+@[a-z0-9-]+\.[a-z]{2,4}$");
        Regex _cuentaR = new Regex(@"^[0-9]{8}$");
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
            Nombre = nombre;
            Email = email;
            Cuenta = cuenta;
            Edad = edad;
        }
        #endregion

        #region Get/Set
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (_nombres.IsMatch(value))
                    _nombre = value;
                else
                    throw new Exception("Error al escribir el nombre!");
            }
        }

        public string Cuenta
        {
            get { return _cuenta; }
            set { 
                if( _cuentaR.IsMatch(value) )
                    _cuenta = value; 
                else
                    throw new Exception("Error al escribir la cuenta!");
            }
        }

        public int Edad
        {
            get { return _edad; }
            set { 
                if( _numeros.IsMatch(value.ToString()) )
                    _edad = value; 
                else
                    throw new Exception("Error al escribir la edad!");
            }
        }

        public string Email
        {
            get { return _email; }
            set {
                if( _emailR.IsMatch(value) )
                    _email = value; 
                else
                    throw new Exception("Error al escribir el correo!");
            }
        }
        #endregion

        public string toString()
        {
            return "Nombre: " + Nombre + " con cuenta: " + Cuenta + " y correo: " + Email + " tiene: " + Edad + " años.";
        }
    }
}
