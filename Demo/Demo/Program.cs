using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Un petit programme qui affiche la table des 8
            // Opérateur pout concaténer : +
            // Saut de ligne : \n

            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            // Constitution de la table
            for (int i=0; i <= valMax; i++)
            {
                // affichage = affichage + i;
                affichage += String.Format("{0:00} * {1} = {2:00}", i, multiple, i*multiple);
                affichage += "\n";
            }

            Console.WriteLine(affichage);

            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
