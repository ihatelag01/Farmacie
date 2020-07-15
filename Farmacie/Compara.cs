using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Farmacie
{
    public class Compara:IComparer 
    {
        public int  Compare(object x,object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Medicamente)x).pret, ((Medicamente)y).pret);
        }
        
    }
}
