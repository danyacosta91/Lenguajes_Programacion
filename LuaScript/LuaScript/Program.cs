using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace LuaScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Lua lua = new Lua();
            lua["_n1"] = 53;
            lua["_n2"] = 112;
            lua["_suma"] = "La suma es: ";
            lua["_mult"] = "La multiplicacion es: ";
            double _n1 = (double)lua["_n1"];
            double _n2 = (double)lua["_n2"];
            string _suma = (string)lua["_suma"];
            string _mult = (string)lua["_mult"];
            Console.WriteLine(_suma + (_n1 + _n2));
            Console.WriteLine(_mult + (_n1 * _n2));
            Console.ReadLine();
        }
    }
}
