using Sort_Busqueda_ArrayL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Busqueda_ArrayL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList persona = new ArrayList();
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona(45755432,"Tito Calderon");
            persona.Add(p1);
            Persona p2 = new Persona(11431221, "Male Sal");
            persona.Add(p2);
            persona.Sort();//Ordena de menor a mayor.
            foreach(Persona per in persona)
            {
                tbxPrueba.Text += per.ToString();
            }
            
        }
    }
}
