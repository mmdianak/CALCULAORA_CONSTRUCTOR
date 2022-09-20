using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    internal class clsuma
    {
        //campos, propiedades, como es 
       private float n1, n2; 
        //constructor
        public clsuma(float n1, float n2)        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public float sumar()
        {
            return (n1 + n2);
        }
        public float restar() 
        {
            return (n1 - n2);
        }
        public float multiplicar()
        {
            return (n1 * n2);
        }
        public float dividir()
        {
            return (n1 / n2);
        }
    }
}
