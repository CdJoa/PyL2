using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Punto
    {
        private int x;
        private int y;
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
             return x;
        }

        public int GetY()
        {
           return y; 
        }


    }
}
