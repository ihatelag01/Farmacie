using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
 

namespace Farmacie
{
   public class ComparaDsc:IComparer
    {
        public int Compare(object x, object y)
        {
            return -(new CaseInsensitiveComparer()).Compare(((Medicamente)x).pret, ((Medicamente)y).pret);
        }
    }
}
