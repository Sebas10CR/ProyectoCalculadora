namespace proyecto_calculadora
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
            txtDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRaizCuadrada = new Button();
            btnClear = new Button();
            btnBorrar = new Button();
            btnFactorial = new Button();
            btnDivision = new Button();
            btnPotencia = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPotenciaDiez = new Button();
            btn5 = new Button();
            btnResta = new Button();
            btnLogaritmo = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSuma = new Button();
            btnCambioDeSigno = new Button();
            button24 = new Button();
            btnIgual = new Button();
            btnCuadrado = new Button();
            btn0 = new Button();
            btnMultiplicacion = new Button();
            btn4 = new Button();
            btn6 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(0, 33);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(611, 23);
            txtDisplay.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnRaizCuadrada, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBorrar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnFactorial, 3, 0);
            tableLayoutPanel1.Controls.Add(btnDivision, 4, 0);
            tableLayoutPanel1.Controls.Add(btnPotencia, 0, 1);
            tableLayoutPanel1.Controls.Add(btn7, 1, 1);
            tableLayoutPanel1.Controls.Add(btn8, 2, 1);
            tableLayoutPanel1.Controls.Add(btn9, 3, 1);
            tableLayoutPanel1.Controls.Add(btnPotenciaDiez, 0, 2);
            tableLayoutPanel1.Controls.Add(btn5, 2, 2);
            tableLayoutPanel1.Controls.Add(btnResta, 4, 2);
            tableLayoutPanel1.Controls.Add(btnLogaritmo, 0, 3);
            tableLayoutPanel1.Controls.Add(btn1, 1, 3);
            tableLayoutPanel1.Controls.Add(btn2, 2, 3);
            tableLayoutPanel1.Controls.Add(btn3, 3, 3);
            tableLayoutPanel1.Controls.Add(btnSuma, 4, 3);
            tableLayoutPanel1.Controls.Add(btnCambioDeSigno, 1, 4);
            tableLayoutPanel1.Controls.Add(button24, 3, 4);
            tableLayoutPanel1.Controls.Add(btnIgual, 4, 4);
            tableLayoutPanel1.Controls.Add(btnCuadrado, 0, 4);
            tableLayoutPanel1.Controls.Add(btn0, 2, 4);
            tableLayoutPanel1.Controls.Add(btnMultiplicacion, 4, 1);
            tableLayoutPanel1.Controls.Add(btn4, 1, 2);
            tableLayoutPanel1.Controls.Add(btn6, 3, 2);
            tableLayoutPanel1.Location = new Point(-3, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(614, 387);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.BackColor = SystemColors.ActiveCaptionText;
            btnRaizCuadrada.ForeColor = SystemColors.ButtonHighlight;
            btnRaizCuadrada.Location = new Point(3, 3);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(116, 66);
            btnRaizCuadrada.TabIndex = 0;
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.OrangeRed;
            btnClear.Location = new Point(125, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 66);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.OrangeRed;
            btnBorrar.Location = new Point(247, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(116, 66);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "⌫";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnFactorial
            // 
            btnFactorial.BackColor = SystemColors.ActiveCaptionText;
            btnFactorial.ForeColor = SystemColors.ButtonHighlight;
            btnFactorial.Location = new Point(369, 3);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(116, 66);
            btnFactorial.TabIndex = 3;
            btnFactorial.Text = "n!";
            btnFactorial.UseVisualStyleBackColor = false;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(491, 3);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(120, 66);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            btnPotencia.BackColor = SystemColors.ActiveCaptionText;
            btnPotencia.ForeColor = SystemColors.ButtonHighlight;
            btnPotencia.Location = new Point(3, 80);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(116, 66);
            btnPotencia.TabIndex = 5;
            btnPotencia.Text = "x^y";
            btnPotencia.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.Location = new Point(125, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(116, 66);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(247, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(116, 66);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(369, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(116, 66);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnPotenciaDiez
            // 
            btnPotenciaDiez.BackColor = SystemColors.ActiveCaptionText;
            btnPotenciaDiez.ForeColor = SystemColors.ButtonHighlight;
            btnPotenciaDiez.Location = new Point(3, 157);
            btnPotenciaDiez.Name = "btnPotenciaDiez";
            btnPotenciaDiez.Size = new Size(116, 66);
            btnPotenciaDiez.TabIndex = 10;
            btnPotenciaDiez.Text = "10^x";
            btnPotenciaDiez.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.Location = new Point(247, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(116, 66);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(491, 157);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(120, 66);
            btnResta.TabIndex = 14;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // btnLogaritmo
            // 
            btnLogaritmo.BackColor = SystemColors.ActiveCaptionText;
            btnLogaritmo.ForeColor = SystemColors.ButtonHighlight;
            btnLogaritmo.Location = new Point(3, 234);
            btnLogaritmo.Name = "btnLogaritmo";
            btnLogaritmo.Size = new Size(116, 66);
            btnLogaritmo.TabIndex = 15;
            btnLogaritmo.Text = "Log";
            btnLogaritmo.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(125, 234);
            btn1.Name = "btn1";
            btn1.Size = new Size(116, 66);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(247, 234);
            btn2.Name = "btn2";
            btn2.Size = new Size(116, 66);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(369, 234);
            btn3.Name = "btn3";
            btn3.Size = new Size(116, 66);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(491, 234);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(120, 66);
            btnSuma.TabIndex = 19;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnCambioDeSigno
            // 
            btnCambioDeSigno.Location = new Point(125, 311);
            btnCambioDeSigno.Name = "btnCambioDeSigno";
            btnCambioDeSigno.Size = new Size(116, 68);
            btnCambioDeSigno.TabIndex = 21;
            btnCambioDeSigno.Text = "±";
            btnCambioDeSigno.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new Point(369, 311);
            button24.Name = "button24";
            button24.Size = new Size(116, 68);
            button24.TabIndex = 23;
            button24.Text = ".";
            button24.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(491, 311);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(120, 68);
            btnIgual.TabIndex = 24;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = SystemColors.ActiveCaptionText;
            btnCuadrado.ForeColor = SystemColors.ButtonHighlight;
            btnCuadrado.Location = new Point(3, 311);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(116, 68);
            btnCuadrado.TabIndex = 20;
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.Location = new Point(247, 311);
            btn0.Name = "btn0";
            btn0.Size = new Size(116, 68);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(491, 80);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(120, 66);
            btnMultiplicacion.TabIndex = 9;
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(125, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(116, 66);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(369, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(116, 66);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(614, 452);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRaizCuadrada;
        private Button btnClear;
        private Button btnBorrar;
        private Button btnFactorial;
        private Button btnDivision;
        private Button btnPotencia;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPotenciaDiez;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btnLogaritmo;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSuma;
        private Button btnCambioDeSigno;
        private Button button24;
        private Button btnIgual;
        private Button btnCuadrado;
        private Button btn0;
        private Button btnMultiplicacion;
        private Button btn4;
    }
}
