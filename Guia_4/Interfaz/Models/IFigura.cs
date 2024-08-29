using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Models
{
    public interface IFigura//Declaramos una interfaz, los metodos no tienen alcance y se declaran como un abstract.
    {
        double CalcularArea();
        double CalcularPerimetro();
    }
}
