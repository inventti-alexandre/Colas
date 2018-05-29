using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasFIFO
{
    public partial class Form1 : Form
    {
        Random rn = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estructura cola = new Estructura();
            int atendidos = 0;
            int timevacio = 0;

            for(int i=0; i < 300; i++)
            {
                int proba =rn.Next(0, 100);
                if(proba <= 35)
                {
                    cola.Agregar();
                }
                if (cola.primero != null)
                {
                    cola.Decrecer();
                    if (cola.primero.Espera == 0)
                    {
                        cola.Eliminar();
                        atendidos++;
                    }
                }
                else if (cola.primero == null)
                {
                    timevacio++;
                }

            }

            textBox1.Text = "Procesos antendidos: " + atendidos + "  tiempo sin procesos: " + timevacio;
        }
    }
}
