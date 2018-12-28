namespace eNutrideal
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_idade = new System.Windows.Forms.TextBox();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.radio_h = new System.Windows.Forms.RadioButton();
            this.radio_m = new System.Windows.Forms.RadioButton();
            this.valorAtividade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actividade";
            // 
            // textBox_idade
            // 
            this.textBox_idade.Location = new System.Drawing.Point(62, 30);
            this.textBox_idade.Name = "textBox_idade";
            this.textBox_idade.Size = new System.Drawing.Size(50, 20);
            this.textBox_idade.TabIndex = 5;
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(62, 93);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(74, 20);
            this.textBox_altura.TabIndex = 6;
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(229, 90);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(74, 20);
            this.textBox_peso.TabIndex = 7;
            // 
            // radio_h
            // 
            this.radio_h.AutoSize = true;
            this.radio_h.Location = new System.Drawing.Point(75, 58);
            this.radio_h.Name = "radio_h";
            this.radio_h.Size = new System.Drawing.Size(61, 17);
            this.radio_h.TabIndex = 8;
            this.radio_h.TabStop = true;
            this.radio_h.Text = "Homem";
            this.radio_h.UseVisualStyleBackColor = true;
            // 
            // radio_m
            // 
            this.radio_m.AutoSize = true;
            this.radio_m.Location = new System.Drawing.Point(154, 60);
            this.radio_m.Name = "radio_m";
            this.radio_m.Size = new System.Drawing.Size(57, 17);
            this.radio_m.TabIndex = 9;
            this.radio_m.TabStop = true;
            this.radio_m.Text = "Mulher";
            this.radio_m.UseVisualStyleBackColor = true;
            // 
            // valorAtividade
            // 
            this.valorAtividade.FormattingEnabled = true;
            this.valorAtividade.Items.AddRange(new object[] {
            "Sedentario - Nenhuma ou Pouca Actividade",
            "Ligeiro - Desporto/Exercicio 1 a 2 Vezes/Semana",
            "Moderado - Desporto/Exercicio 3 a 4 Vezes/Semana",
            "Muito Activo -Desporto/Exercicio 5 a 7  Vezes/Semana",
            "Super Activo - Exercicio/Desporto muito duro ou trabalho físico"});
            this.valorAtividade.Location = new System.Drawing.Point(90, 132);
            this.valorAtividade.Name = "valorAtividade";
            this.valorAtividade.Size = new System.Drawing.Size(195, 21);
            this.valorAtividade.TabIndex = 10;
            this.valorAtividade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Resultado";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 274);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorAtividade);
            this.Controls.Add(this.radio_m);
            this.Controls.Add(this.radio_h);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.textBox_idade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Calculadora de Calorias";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_idade;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.RadioButton radio_h;
        private System.Windows.Forms.RadioButton radio_m;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox valorAtividade;
    }
}