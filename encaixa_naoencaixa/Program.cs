using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace encaixa_naoencaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < a; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                string s = x[0];
                string v = x[1];
                bool res = s.EndsWith(v);
                if ( res )
                {
                    Console.WriteLine("encaixa");
                }
                else { Console.WriteLine("nao encaixa"); }





            }
        }
    }
}
