using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFigura
{
    class Circle:Figure
    {

        public override float Area(float radius, float height=0)
        {
            return radius*radius*(float)Math.PI;
        }

        public override float Perimetre(float radius, float side2=0)
        {
            return radius*2*(float)Math.PI;
        }
    }
}
