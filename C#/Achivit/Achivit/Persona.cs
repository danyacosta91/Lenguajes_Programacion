using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Achivit
{
    public class Persona
    {
        #region Variables
        private string _nombre;
        private string _email;
        private int _edad;
        Regex _nombres = new Regex(@"^[A-Za-z][A-Za-zñ,\s-,\s(,\s,\s.)]+$");
        Regex _numeros = new Regex("^[0-9]+$");
        Regex _emailR = new Regex(@"^[a-z0-9_.]+@[a-z0-9-]+\.[a-z]{2,4}$");
        #endregion

        #region Constructores
        public Persona()
        {
            _nombre = "";
            _email = "";
            _edad = 0;
        }

        public Persona(string nombre, string email, int edad)
        {
            Nombre = nombre;
            Email = email;
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

        public class Alumno
        {
            #region Variables
            private string _cuenta;
            private string _clases;
            Regex _nombres = new Regex(@"^[A-Za-z][A-Za-zñ,\s-,\s(,\s,\s.)]+$");
            Regex _cuentaR = new Regex(@"^[0-9]{8}$");
            #endregion

            #region Constructores
            public Alumno()
            {
                _cuenta = "";
                _clases = "";
            }

            public Alumno(string cuenta, string clases) 
            {
                Cuenta = cuenta;
                Clases = clases;
            }

            #endregion

            #region Get/Set
            public string Cuenta
            {
                get { return _cuenta; }
                set
                {
                    if (_cuentaR.IsMatch(value))
                        _cuenta = value;
                    else
                        throw new Exception("Error al escribir la cuenta!");
                }
            }

            public string Clases
            {
                get { return _clases; }
                set { 
                    if( _nombres.IsMatch(value) )
                        _clases = value; 
                    else
                        throw new Exception("Error al escribir el nombre de las clases!");
                }
            }
            #endregion
        }
    }
}
