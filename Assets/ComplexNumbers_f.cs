using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class ComplexNumbers_f
    {
        public float real = 0.0f;
        public float image = 0.0f;
        public static ComplexNumbers_f Product(ComplexNumbers_f a, ComplexNumbers_f b)
        {
            ComplexNumbers_f c=new ComplexNumbers_f();
            c.real = a.real * b.real - a.image * b.image;
            c.image = a.image * b.real + a.real * b.image;
            return c;
        }
        public ComplexNumbers_f(float a=0.0f,float b=0.0f)
        {
            real = a;
            image = b;
        }
    }
}
