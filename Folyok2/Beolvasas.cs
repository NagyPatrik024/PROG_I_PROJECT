using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Folyok2
{
    class Beolvasas
    {
        private string kerdesfolyo;
        public string KerdesfolyoGetter()
        {
            return kerdesfolyo;
        }
        public Folyo[] beolvas()
        {
            StreamReader sr = new StreamReader("FOLYO.BE.txt");
            int folyokszama = int.Parse(sr.ReadLine());
            Folyo[] f = new Folyo[folyokszama];
            int lepteto = 0;
            kerdesfolyo = "";

            while (!sr.EndOfStream)
            { 
                Folyo temp = new Folyo();
                temp.folyonev = sr.ReadLine();
                temp.kifolyas = sr.ReadLine();
                f[lepteto] = temp;
                lepteto++;
                //Utolsó sort így mentem el
                if (lepteto == folyokszama)
                {
                    kerdesfolyo = sr.ReadLine();
                }
            }
            return f;
        }
    }
}
