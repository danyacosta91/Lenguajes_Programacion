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
            lua["num1"] = 2;
            lua["num2"] = 45;
            lua["palabra"] = "La suma es: ";
            double num = (double)lua["num1"];
            double num2 = (double)lua["num2"];
            string palabra = (string)lua["palabra"];
            Console.WriteLine(palabra + (num2 + num));
            Console.ReadLine();
        }
    }
}
