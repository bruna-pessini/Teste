namespace ProjetoSoma
{
    partial class frmprincipal
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
            this.LBLPrimeiroNumero = new System.Windows.Forms.Label();
            this.txbprimeironumero = new System.Windows.Forms.TextBox();
            this.txbsegundonumero = new System.Windows.Forms.TextBox();
            this.LBLSegundoNumero = new System.Windows.Forms.Label();
            this.btnsomar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLPrimeiroNumero
            // 
            this.LBLPrimeiroNumero.AutoSize = true;
            this.LBLPrimeiroNumero.Location = new System.Drawing.Point(17, 20);
            this.LBLPrimeiroNumero.Name = "LBLPrimeiroNumero";
            this.LBLPrimeiroNumero.Size = new System.Drawing.Size(123, 13);
            this.LBLPrimeiroNumero.TabIndex = 0;
            this.LBLPrimeiroNumero.Text = "Digite o Primeiro Numero";
            // 
            // txbprimeironumero
            // 
            this.txbprimeironumero.Location = new System.Drawing.Point(17, 36);
            this.txbprimeironumero.Name = "txbprimeironumero";
            this.txbprimeironumero.Size = new System.Drawing.Size(121, 20);
            this.txbprimeironumero.TabIndex = 1;
            this.txbprimeironumero.Text = "1";
            this.txbprimeironumero.TextChanged += new System.EventHandler(this.txbprimeironumero_TextChanged);
            // 
            // txbsegundonumero
            // 
            this.txbsegundonumero.Location = new System.Drawing.Point(17, 102);
            this.txbsegundonumero.Name = "txbsegundonumero";
            this.txbsegundonumero.Size = new System.Drawing.Size(121, 20);
            this.txbsegundonumero.TabIndex = 3;
            this.txbsegundonumero.Text = "2";
            // 
            // LBLSegundoNumero
            // 
            this.LBLSegundoNumero.AutoSize = true;
            this.LBLSegundoNumero.Location = new System.Drawing.Point(17, 86);
            this.LBLSegundoNumero.Name = "LBLSegundoNumero";
            this.LBLSegundoNumero.Size = new System.Drawing.Size(129, 13);
            this.LBLSegundoNumero.TabIndex = 2;
            this.LBLSegundoNumero.Text = "Digite o Segundo Numero";
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(40, 151);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(75, 23);
            this.btnsomar.TabIndex = 4;
            this.btnsomar.Text = "Somar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(14, 263);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(121, 151);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(40, 201);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(121, 201);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 329);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txbsegundonumero);
            this.Controls.Add(this.LBLSegundoNumero);
            this.Controls.Add(this.txbprimeironumero);
            this.Controls.Add(this.LBLPrimeiroNumero);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frmprincipal";
            this.Text = "Somar dois numeros";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPrimeiroNumero;
        private System.Windows.Forms.TextBox txbprimeironumero;
        private System.Windows.Forms.TextBox txbsegundonumero;
        private System.Windows.Forms.Label LBLSegundoNumero;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

