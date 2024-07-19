namespace CalculadoraBasicaUmBotao.View
{
    partial class CalculadoraBasica
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
            label1 = new Label();
            lbl_Display = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Calcular = new Button();
            tbx_valor1 = new TextBox();
            tbx_valor2 = new TextBox();
            tbx_Operador = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 28);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Básica";
            // 
            // lbl_Display
            // 
            lbl_Display.BackColor = SystemColors.Info;
            lbl_Display.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Display.Location = new Point(84, 79);
            lbl_Display.Name = "lbl_Display";
            lbl_Display.Size = new Size(196, 40);
            lbl_Display.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F);
            label3.Location = new Point(57, 139);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F);
            label4.Location = new Point(56, 188);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor2:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F);
            label5.Location = new Point(45, 225);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Operador:";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.Location = new Point(245, 278);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(117, 45);
            btn_Calcular.TabIndex = 5;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // tbx_valor1
            // 
            tbx_valor1.Location = new Point(128, 137);
            tbx_valor1.Name = "tbx_valor1";
            tbx_valor1.Size = new Size(100, 23);
            tbx_valor1.TabIndex = 6;
            // 
            // tbx_valor2
            // 
            tbx_valor2.Location = new Point(128, 180);
            tbx_valor2.Name = "tbx_valor2";
            tbx_valor2.Size = new Size(100, 23);
            tbx_valor2.TabIndex = 7;
            // 
            // tbx_Operador
            // 
            tbx_Operador.Location = new Point(128, 225);
            tbx_Operador.Name = "tbx_Operador";
            tbx_Operador.Size = new Size(100, 23);
            tbx_Operador.TabIndex = 8;
            // 
            // CalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 352);
            Controls.Add(tbx_Operador);
            Controls.Add(tbx_valor2);
            Controls.Add(tbx_valor1);
            Controls.Add(btn_Calcular);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_Display);
            Controls.Add(label1);
            Name = "CalculadoraBasica";
            Text = "CalculadoraBasica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Display;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Calcular;
        private TextBox tbx_valor1;
        private TextBox tbx_valor2;
        private TextBox tbx_Operador;
    }
}