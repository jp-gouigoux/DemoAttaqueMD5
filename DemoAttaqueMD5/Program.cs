using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttaqueMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] vecteur = File.ReadAllBytes("Dependances.dll");
            if (vecteur[123] == 0xab)
                Console.WriteLine("Un virus collecte vos données !");
            else
                Console.WriteLine("SALVIA SPO se lance...");
        }
    }
}
