using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemamRadDana
{
    internal class postava
    {
        public string Jmeno = "ahoj";
        
        public postava(string name)
        {
            Jmeno = name;
        }

        public bool getJmenoPostavy(postava p)
        {
            if(this.Jmeno.Length <= 10)
                return true;
            else
            return false;
        }
    }
    
}
