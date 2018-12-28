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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorAtividade.Items.Add("Sedentario - Nenhuma ou Pouca Actividade");
            valorAtividade.Items.Add("Ligeiro - Desporto/Exercicio  1 a 2 Vezes/Semana");
            valorAtividade.Items.Add("Moderado - Desporto/Exercicio 3 a 4 Vezes/Semana");
            valorAtividade.Items.Add("Muito Activo - Desporto/Exercicio 5 a 7 Vezes/Semana");
            valorAtividade.Items.Add("Super Activo - Exercício/Desporto muito duro ou trabalho físico");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            double altura;
            double peso;
            idade = int.Parse(textBox_idade.Text);
            altura = double.Parse(textBox_altura.Text);
            peso = double.Parse(textBox_peso.Text);
        
         
            if (radio_h.Checked)
            {
                //homem 
                double TMB = (10*peso)+(6.25*altura)-(5*idade)+5;
                double actividade = -1;

                switch (valorAtividade.SelectedIndex)
                {
                    case 0: // Sedentario
                        actividade = 1.2;
                        break;

                    case 1: //Ligeiro
                        actividade = 1.75;
                        break;

                    case 2: //moderado
                        actividade = 1.550;
                        break;

                    case 3: //muito ativo
                        actividade = 1.725;
                            break;

                    case 4: //super ativo
                        actividade = 1.9;
                        break;

                    default:
                        MessageBox.Show("Escolha um valor de Actividade!");
                        return;

                }

                double CalculadoraCalorias = TMB * actividade;
                    

            }

            else
            {
                //mulher
                double TMB = (10 * peso) + (6.25 * altura) - (5 * idade) - 161;
                double actividade = -1;

                switch (valorAtividade.SelectedIndex)
                {
                    case 0: // Sedentario
                        actividade = 1.2;
                        break;

                    case 1: //Ligeiro
                        actividade = 1.75;
                        break;

                    case 2: //moderado
                        actividade = 1.550;
                        break;

                    case 3: //muito ativo
                        actividade = 1.725;
                        break;

                    case 4: //super ativo
                        actividade = 1.9;
                        break;

                    default:
                        MessageBox.Show("Escolha um valor de Actividade!");
                        return;

                }

                double CalculadoraCalorias = TMB * actividade;



            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
