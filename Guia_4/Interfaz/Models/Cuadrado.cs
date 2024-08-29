using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Models
{
     public class Cuadrado:Rectangulo,IComparable
    {
        public Cuadrado(double lado) :base(lado,lado)
        {
            
        }
        public override string ToString()
        {
            double Res = CalcularArea();
            double per = CalcularPerimetro();
            string Ver = $"Area del Cuadrado:{Res:f2}| |Perimetro{per:f2}\r\n";
            return Ver;
        }


    }
}
