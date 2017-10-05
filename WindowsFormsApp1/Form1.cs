using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Clase que muestra el nombre, la edad y el dia de la semana que es.
/// </summary>

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int age;
        private int dayWeek;
        public String str = "Lunes";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para calcular el dia de la semana que es eligiendo un numero del 1 al 7.
        /// </summary>
        /// <param name="n">Dia de la semana que es</param>
        /// <returns></returns>
        private void Day_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                str = ((RadioButton)sender).Text;
            }
        }

        /// <summary>
        /// Metodo para que cuando haga click el usuario segun los datos introducidos muestre una cosa u otra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AgeUser();

        }

        /// <summary>
        /// Metodo que calcula si el Usuario es menor o mayor de edad y muestra los datos.
        /// </summary>
        private void AgeUser()
        {

            if (!String.IsNullOrEmpty(tBOne.Text)&&ageBox.Value != 0)
            {
                if (ageBox.Value >= 18)
                {

                    label4.Text = "La persona llamada " + tBOne.Text + " es mayor de edad y estamos a " + str + ".";
                }

                else
                {
                    label4.Text = "La persona llamada " + tBOne.Text + " es menor de edad y estamos a " + str + ". " + (SatDay.Checked || SunDay.Checked ? "¡NO HAY CLASES!" : "Por desgracia hay clases...");


                } 
            }

            else
            {

                label4.Text = "Datos invalidos";
            }
        }

       




    }


   }

