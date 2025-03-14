using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemamRadDana
{
    public class HerniPostava
    {
        public string Jmeno { get; set; }
        public int Level { get; set; }
        public int PositionX { get; }
        public int PositionY { get; }

        public bool GetJmeno()
        {
            if (pos.Jmeno.Length <= 10)
                return true;
            else
                return false;
        }

        public int GetLevel()
        {
            return pos.Level;
        }
        public void GetPosition(out int x, out int y)
        {
            x = pos.POSX;
            y = pos.POSY;
        }
    }
}
