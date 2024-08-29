using Interfaz.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //IFigura[] figuras = new IFigura[10];
       
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            var fig = new ArrayList();
            fig.Add(new Cuadrado(4));
            fig.Add(new Circulo(47));
            fig.Add(new Rectangulo(12, 30));
            fig.Sort();
            foreach (IFigura f in fig)
            {
                tbxPrueba.Text += f.ToString();

            }

            //figuras[1] = new Circulo(47);
            //figuras[2] = new Rectangulo(12, 30);

            /*foreach (IFigura i in figuras)
            {
                if(i is Cuadrado)
                {
                    tbxPrueba.Text += i.ToString();
                }
                else
                {
                    if(i is Circulo)
                    {
                        tbxPrueba.Text += i.ToString();
                    }
                    else
                    {
                        if(i is Rectangulo)
                        {
                            tbxPrueba.Text += i.ToString();
                        }
                    }
                }*/
                
            
        }
    }
}
