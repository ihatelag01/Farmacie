using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    class Medicamente
    {
         public string nume { get; set; }

        public double pret { get; set; }
        public string infoComplet { get { return nume.ToUpper() + " " + Convert.ToString(pret) + " " + "RON" + "," + Convert.ToString(cantitate) + " " + "buc."; } }
        public int cantitate { get; set; }
        public Tip TIP { get; set; }
        public Prescriptie PRES { get; set; }
        public enum Tip
        {   
            NEDEFINIT=0,
            COMPRIMATE=1,
            SIROP=2,
            UNGUENT=3,
        }
        public enum Prescriptie
        {
            DA=1,
            NU=0,
        }

        public  Medicamente()
        {
            pret = 0;
            string nume =string.Empty;
            cantitate = 0;
            TIP = 0;
            PRES = 0;
            

      
        }
        
          
         public   Medicamente(string _nume,double _pret,int _tip,int _pres)
        {
            nume = _nume;
            pret = _pret;
            TIP = (Tip)_tip;
            PRES = (Prescriptie)_pres;
        }

        public string Afisare()
        {
            if (nume.Length == 0)

                return "NEDEFINIT";
            else
                return string.Format("{0} costa {1} RON,tip {2},necesita prescriptie {3}.\n", nume.ToUpper(), pret,TIP,PRES);
        }
        public Medicamente(string info)
        {
            string[] _info = info.Split(",");

            int i = 0;
            foreach (var den in _info)
            {
                nume = _info[0];
                i++;
                 
            }
          
            foreach(var val in _info )
            {
                pret = Convert.ToInt32(_info[1]);
                i++;
            }
            
             


            }
        public int Compara(Medicamente ob)
        {
            if (pret > ob.pret) 
            {
                Console.WriteLine("Pret mai mare!");
                return 1;
            }

            if (pret < ob.pret)
            {
                Console.WriteLine("Pret mai mic!");
                return -1;
            }

            else
            {
                Console.WriteLine("Preturi egale!");
                return 0;
            }
                
             
        }


            
        }
       
    }
        
    

