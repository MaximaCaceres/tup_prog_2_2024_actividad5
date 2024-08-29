using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Models
{
    internal class Circulo : IFigura,IComparable// hereda la interfaz.
    {
        public double Radio{ get; private set; }
        #region Metodos
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public  double CalcularArea()// sobre-escribe el metodo heredado pero sin el override. Y le damos un alcance
        {
            double Res = Math.PI * Radio;
            return Res;
        }
        public override string ToString()
        {
            double res = CalcularArea();
            double per = CalcularPerimetro();
            string Ver = $"Area del Circulo:{res:f2}| |Perimetro{per:f2}\r\n";
            return Ver;
        }
        public  double CalcularPerimetro()// sobre-escribe el metodo heredado pero sin el override. Y le damos un alcance
        {
            double Res, diametro;
            diametro = Radio * 2;
            return Res = Math.PI * diametro;
        }
        public int CompareTo(object obj)//le pasa un obj 
        {
            Circulo circu = obj as Circulo;// hacemos un casteo para asegurarnos de que es un circulo
            double area = CalcularArea();
            if (circu != null)
               return area.CompareTo(circu.CalcularArea());
               return 1;
        }

        #endregion
    }
}
