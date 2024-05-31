using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class triangulo : Figura
    {
        private float lado2;
        private float lado3;

        public float Lado2
        {
            set
            {
                if (value < 0)
                {
                    lado2 = 0;
                }
                else
                {
                    lado2 = value;
                }
            }
            get
            {
                return lado2;
            }
        }

        public float Lado3
        {
            set
            {
                if (value < 0)
                {
                    lado3 = 0;
                }
                else
                {
                    lado3 = value;
                }
            }
            get
            {
                return lado3;
            }
        }

        public triangulo(float lado1, float lado2, float lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }

        public override float area()
        {
          
            float s = (Lado1 + Lado2 + Lado3) / 2;
            return ((Lado1) * (Lado2) * (Lado3);
        }

        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public override float volumen()
        {
            // Los triángulos son figuras bidimensionales, por lo que no tienen volumen
            return 0;
        }
    }
}

