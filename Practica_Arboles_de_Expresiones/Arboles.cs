using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_Arboles_de_Expresiones
{
    static class Arboles
    {
        static public bool convert(string infix) {
            List<char> operadores = new List<char> { '*', '/', '+', '-' };

            int pri = 0;
            string[] result = { infix, "" };

            Stack<char> stack = new Stack<char>();

            foreach (char item in infix.ToCharArray())
            {
                if (operadores.Contains(item))
                    stack.Push(item);
            }


            return false;

            
        
        }
    }
}
