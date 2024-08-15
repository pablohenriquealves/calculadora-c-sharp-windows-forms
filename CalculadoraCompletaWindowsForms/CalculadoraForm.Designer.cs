namespace CalculadoraCompletaWindowsForms
{
    partial class Calculadora
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
            btnVirgula = new Button();
            btnIgual = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMais = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMenos = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicar = new Button();
            btn7 = new Button();
            btnDividir = new Button();
            btnClean = new Button();
            btnDelete = new Button();
            txtResultado = new TextBox();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(13, 349);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(92, 60);
            btnVirgula.TabIndex = 0;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(205, 349);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(92, 60);
            btnIgual.TabIndex = 2;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(109, 349);
            btn0.Name = "btn0";
            btn0.Size = new Size(92, 60);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(109, 283);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 60);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(205, 283);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 60);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(303, 349);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(92, 60);
            btnMais.TabIndex = 5;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnAdicao_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(13, 283);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 60);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(109, 217);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 60);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(205, 217);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 60);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(303, 283);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(92, 60);
            btnMenos.TabIndex = 9;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnSubtracao_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(13, 217);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 60);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(109, 151);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 60);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(205, 151);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 60);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(303, 217);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(92, 60);
            btnMultiplicar.TabIndex = 13;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(13, 151);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 60);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(303, 151);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(92, 60);
            btnDividir.TabIndex = 17;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(205, 85);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(92, 60);
            btnClean.TabIndex = 22;
            btnClean.Text = "C";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 60);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(11, 24);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(384, 27);
            txtResultado.TabIndex = 24;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(13, 28);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 25;
            lblOperacao.Click += lblOperacao_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 420);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            Controls.Add(btnClean);
            Controls.Add(btnDelete);
            Controls.Add(btnDividir);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnMenos);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnMais);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVirgula;
        private Button btnIgual;
        private Button btn0;
        private Button btn2;
        private Button btn3;
        private Button btnMais;
        private Button btn1;
        private Button btn5;
        private Button btn6;
        private Button btnMenos;
        private Button btn4;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicar;
        private Button btn7;
        private Button btnDividir;
        private Button btnClean;
        private Button btnDelete;
        private TextBox txtResultado;
        private Label lblOperacao;
    }
}
