using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNutrideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double.TryParse(textBox_peso.Text, out double peso);

            double.TryParse(textBox_altura.Text, out double altura);

           /*/ se o introduzido um valor errado o codigo não é executado
            if (altura == null)
            {
                return;
            }*/

            int.TryParse(textBox_idade.Text, out int idade);

            //calculos

            double peso_ideal = 0;

            if (radio_h.Checked)
            {
                //homem
                peso_ideal = (10 * peso + 6.25 * altura - 5 * idade) + 5;

            }
            else
            {
                //mulher
                peso_ideal = (10 * peso + 6.25 * altura - 5 * idade) + 5;
            }

            StringBuilder str = new StringBuilder("Peso Ideal:" + peso_ideal.ToString("0.0") + "Kg");

            //comparar peso + peso ideal

            if(textBox_peso.Text != "")
            {
              
                    if(peso_ideal < peso)
                    {
                        str.Append(Environment.NewLine + "Deve Emagrecer"+ (peso-peso_ideal).ToString("0.0") + "Kg");
                    }
                    else if (peso_ideal > peso)
                    {
                        str.Append(Environment.NewLine + "Esta abaixo do peso" + (peso_ideal - peso).ToString("0.0") + "Kg");
                    }
                    else 
                      {
  
                        str.Append(Environment.NewLine + "Parabéns está com o Peso Ideal!" );
               
                        }
                
            }
 

            MessageBox.Show(str.ToString());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox_altura.Text != "" ? true : false;
        }
    }
}
