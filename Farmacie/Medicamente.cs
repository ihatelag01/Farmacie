using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    class Medicamente
    {
        string nume;
        double pret;

        public  Medicamente()
        {
            pret = 0;
            string nume =string.Empty;
            

      
        }
        
          
         public   Medicamente(string _nume,double _pret)
        {
            nume = _nume;
            pret = _pret;
        }

        public string Afisare()
        {
            if (nume.Length == 0)

                return "NEDEFINIT";
            else
                return string.Format("{0} {1} RON\n", nume, pret);
        }
       
    }
        
    }

