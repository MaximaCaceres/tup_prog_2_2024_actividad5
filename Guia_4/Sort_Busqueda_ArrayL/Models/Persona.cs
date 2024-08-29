using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Busqueda_ArrayL.Models
{
    public class Persona: IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni,string nombre)
        {
            Nombre = nombre;
            DNI = dni;
        }
        public override string ToString()
        {
            string ver = $"{Nombre} {DNI}\r\n";
            return ver ;
        }
        public int CompareTo(object obj)
        {
            Persona per = obj as Persona;
            if (per != null)
                return per.CompareTo(per.DNI);
            return 1;
        }
    }
}
