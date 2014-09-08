using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achivit
{
    class Fraction
    {
        #region Variables
        private int _num;
        private int _den;
        #endregion

        #region Get/Set
        public int Numerador
        {
            get { return _num; }
            set { _num = value; }
        }

        public int Denominador
        {
            get { return _den; }
            set { _den = value; }
        }
        #endregion

        public Fraction(int numerador, int denominador)
        {
            _num = numerador;
            _den = denominador;
        }

        public Fraction Multiplicar(Fraction frac)
        {
            return new Fraction(frac.Denominador * Numerador, frac.Numerador * Denominador);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Denominador * f2.Numerador, f1.Numerador * f2.Denominador);
        }
    }
}
