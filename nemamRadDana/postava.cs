using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemamRadDana
{
    public class postava
    {

       
        public postava(string name)
        {
            Jmeno = name;
            POSX= 0;
            POSY = 0;
        }

        public int getLevel()
        {
            return Level;
        }


    }
    
}
