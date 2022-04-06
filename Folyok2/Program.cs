using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Folyok2
{
    class Program
    {

        static void Main(string[] args)
        {
            Beolvasas beolvasas = new Beolvasas();
            Folyo[] f = beolvasas.beolvas();
            string kerdesfolyo = beolvasas.KerdesfolyoGetter();

            //A feladata kiirása
            Afeladat a = new Afeladat();
            string[] Atomb = a.FeladatA(kerdesfolyo, f);
            StreamWriter sw = new StreamWriter("FOLYO.KI.txt");
            sw.WriteLine(Atomb.Length);
            for (int i = 0; i < Atomb.Length; i++)
            {  
                sw.WriteLine(Atomb[i]);
            }
            //B feladat kiírása
            Bfeladat b = new Bfeladat();
            string[] Btomb = b.FeladatB(kerdesfolyo, f).Split(',');
            sw.WriteLine(Btomb.Length-1);
            for (int i = 0; i < Btomb.Length-1; i++)
            {
                sw.WriteLine(Btomb[i]);
            }
            sw.Close();
        }     
    }
}
