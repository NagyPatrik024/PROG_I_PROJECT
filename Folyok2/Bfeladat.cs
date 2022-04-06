using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folyok2
{
    class Bfeladat
    {
        public string FeladatB(string kerdesfolyo, Folyo[] f)
        {
            
            string ideiglenes = kerdesfolyo; 
            string Bfeladat = "";
            //csak simán kimentegetem, a feladat leírásban le van szögezve hogy egy folyó csak egy folyóba folyhat, ezért ez könnyű volt.
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i].folyonev == ideiglenes)
                {
                    Bfeladat += f[i].kifolyas + ",";
                    ideiglenes = f[i].kifolyas;
                }
            }
            return Bfeladat;
        }
    }
}
