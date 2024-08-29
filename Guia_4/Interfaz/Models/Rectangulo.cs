using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Models
{
    public class Rectangulo : IFigura,IComparable// hereda la interfaz.
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }
        #region Metodos
        public Rectangulo(double largo, double ancho) 
        {
            Largo = largo;
            Ancho = ancho;
        }
        public  double CalcularArea()// sobre-escribe el metodo heredado pero sin el override. Y le damos un alcance
        {
            double area = Ancho * Largo;
            return area;
        }
        public override string ToString()
        {
           double Res= CalcularArea();
            double per = CalcularPerimetro();
            string Ver = $"Area del Rectangulo:{Res:f2}| |Perimetro{per:f2}\r\n";
            return Ver;
        }
        public  double CalcularPerimetro()// sobre-escribe el metodo heredado pero sin el override. Y le damos un alcance
        {
            double Res = 2 * (Ancho + Largo);
            return Res;
        }
        public int CompareTo(object obj)//le pasa un obj 
        {
            Rectangulo circu = obj as Rectangulo;// hacemos un casteo para asegurarnos de que es un circulo
            double area = CalcularArea();
            if (circu != null)
                return area.CompareTo(circu.CalcularArea());
            return 1;
        }

        #endregion
    }
}
