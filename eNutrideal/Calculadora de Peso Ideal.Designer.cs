using System;

namespace eNutrideal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_idade = new System.Windows.Forms.TextBox();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.radio_h = new System.Windows.Forms.RadioButton();
            this.radio_m = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // textBox_idade
            // 
            this.textBox_idade.Location = new System.Drawing.Point(64, 28);
            this.textBox_idade.Name = "textBox_idade";
            this.textBox_idade.Size = new System.Drawing.Size(33, 20);
            this.textBox_idade.TabIndex = 3;
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(184, 28);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(59, 20);
            this.textBox_altura.TabIndex = 4;
            this.textBox_altura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radio_h
            // 
            this.radio_h.AutoSize = true;
            this.radio_h.Location = new System.Drawing.Point(92, 110);
            this.radio_h.Name = "radio_h";
            this.radio_h.Size = new System.Drawing.Size(61, 17);
            this.radio_h.TabIndex = 5;
            this.radio_h.TabStop = true;
            this.radio_h.Text = "Homem";
            this.radio_h.UseVisualStyleBackColor = true;
            // 
            // radio_m
            // 
            this.radio_m.AutoSize = true;
            this.radio_m.Location = new System.Drawing.Point(184, 110);
            this.radio_m.Name = "radio_m";
            this.radio_m.Size = new System.Drawing.Size(57, 17);
            this.radio_m.TabIndex = 6;
            this.radio_m.TabStop = true;
            this.radio_m.Text = "Mulher";
            this.radio_m.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(103, 70);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(51, 20);
            this.textBox_peso.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 207);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_m);
            this.Controls.Add(this.radio_h);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.textBox_idade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Peso Ideal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_idade;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.RadioButton radio_h;
        private System.Windows.Forms.RadioButton radio_m;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.Label label4;
    }
}

