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
            
        }
       
    }
        
    

