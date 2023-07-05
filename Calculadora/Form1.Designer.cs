namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            somar = new Button();
            primeiroNumero = new TextBox();
            segundoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(238, 226);
            somar.Name = "somar";
            somar.Size = new Size(112, 34);
            somar.TabIndex = 11;
            somar.Text = "somar";
            somar.UseVisualStyleBackColor = true;
            somar.Click += button12_Click;
            // 
            // primeiroNumero
            // 
            primeiroNumero.Location = new Point(217, 134);
            primeiroNumero.Name = "primeiroNumero";
            primeiroNumero.Size = new Size(150, 31);
            primeiroNumero.TabIndex = 12;
            // 
            // segundoNumero
            // 
            segundoNumero.Location = new Point(217, 189);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(150, 31);
            segundoNumero.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 137);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 14;
            label1.Text = "1º Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 195);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 15;
            label2.Text = "2º Número";
            label2.Click += label2_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(373, 164);
            resultado.Name = "resultado";
            resultado.Size = new Size(22, 25);
            resultado.TabIndex = 16;
            resultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(segundoNumero);
            Controls.Add(primeiroNumero);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button somar;
        private TextBox primeiroNumero;
        private TextBox segundoNumero;
        private Label label1;
        private Label label2;
        private Label resultado;
    }
}