using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
   public class Medicamente
    {
        public string nume { get; set; }

        public double pret { get; set; }
        public string infoComplet { get { return nume.ToUpper() + "," + Convert.ToString(pret) + " " + "RON" + "," +Convert.ToString(TIP) + ","+Convert.ToString(PRES)  ; } }
        public int cantitate { get; set; }
        public Tip TIP { get; set; }
        public Prescriptie PRES { get; set; }
        public enum Tip
        {
            NEDEFINIT = 0,
            COMPRIMAT = 1,
            SIROP = 2,
            UNGUENT = 3,
        }
        public enum Prescriptie
        {
            DA = 1,
            NU = 0,
        }

        public Medicamente() //constructor implicit
        {
            pret = 0;
            string nume = string.Empty;
            cantitate = 0;
            TIP = 0;
            PRES = 0;



        }


        public Medicamente(string _nume, double _pret, int _tip, int _pres) //constructor parametrii
        {
            nume = _nume;
            pret = _pret;
            TIP = (Tip)_tip;
            PRES = (Prescriptie)_pres;
        }

        public string Afisare() //conversie la sir
        {
            if (nume.Length == 0)

                return "NEDEFINIT";
            else
                return string.Format("{0},pret {1} RON,tip {2},necesita prescriptie {3}.\n", nume.ToUpper(), pret, TIP, PRES);
        }
        public Medicamente(string info) //constructor sir de caractere
        {
            string[] _info = info.Split(",");

            int i = 0;
            foreach (var den in _info)
            {
                nume = _info[0];
                i++;

            }

            foreach (var val in _info)
            {
                pret = Convert.ToDouble(_info[1]);
                i++;
            }
           
            foreach(var tp in _info)
            {
                TIP = (Tip)Enum.Parse(typeof(Tip), _info[2]);
                i++;
            }
            foreach (var pr in _info)
            {
                PRES=(Prescriptie)Enum.Parse(typeof(Prescriptie),_info[3]);
                
            }
            


        }




        public int Compara(Medicamente ob) //metoda comparare pret
        {
            
            if (pret > ob.pret)


                return 1;


            if (pret < ob.pret)


                return -1;


            else


                return 0;




        }
        public string ConversieLaSir_PentruFisier()
        {

            string s = string.Format("{0},{1},{2},{3}", nume.ToUpper(),pret,TIP,PRES);


            return s;
        }



    }
}





