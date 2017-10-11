using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFigura
{
    class Triangle:Figure
    {

        public override float Area(float baseSide, float height)
        {
            return baseSide*height/2;
        }

        public override float Perimetre(float side, float side2=0)
        {
            return side*3;
        }



    }
}
