using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folyok2
{
    class Afeladat
    {
        public string[] FeladatA(string kerdesfolyo, Folyo[] f)
        {
            string idg = "";
            //Itt töltöm fel a változóknak a befolyok részeit
            for (int i = 0; i < f.Length; i++)
            {
                idg = f[i].folyonev;
                for (int j = 0; j < f.Length; j++)
                {
                    if (f[j].kifolyas == idg)
                    {
                        f[i].befolyok += f[j].folyonev + ",";
                    }
                }
            }
            string osszesitett = "";
            string temp = "";
            string[] temptomb = { };
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i].folyonev != kerdesfolyo)
                {
                    string ideiglenes = f[i].folyonev;
                    temp = f[i].folyonev + ",";
                    int j = 0;
                    while (j < f.Length)
                    {
                        if (f[j].folyonev == ideiglenes && f[j].folyonev != kerdesfolyo)
                        {
                                temp += f[j].kifolyas + ",";
                                ideiglenes = f[j].kifolyas;
                                j = -1;
                        }
                        j++;
                    }
                }
                if (temp != "")
                {
                    temptomb = temp.Split(',');
                    if (BenneVan(temptomb, kerdesfolyo))
                    {
                        for (int k = 0; k < temptomb.Length; k++)
                        {
                            if (temptomb[k] != null)
                            { osszesitett += temptomb[k] + ","; }
                        }
                    }
                }
                temp = "";
            }
            string[] Utolsolepes = osszesitett.Split(',');
            osszesitett = "";
            string[] Mentett = new string[Utolsolepes.Length];
            int mutato = 0;
            for (int i = 0; i < Utolsolepes.Length; i++)
            {
                if (Utolsolepes[i] != "" && !BenneVan(Mentett, Utolsolepes[i]) && Utolsolepes[i] != kerdesfolyo)
                {
                    Mentett[mutato] = Utolsolepes[i];
                    mutato++;
                }
            }
            string[] ujtomb = new string[mutato];
            for (int i = 0; i < mutato; i++)
            {
                ujtomb[i] = Mentett[i];
            }
            return ujtomb;
            
        }
        static bool BenneVan(string[] tipus, string ertek)
        {
            int i = 0;
            while (i < tipus.Length && tipus[i] != ertek)
            {
                i++;
            }
            return i < tipus.Length;
        }
    }
}
