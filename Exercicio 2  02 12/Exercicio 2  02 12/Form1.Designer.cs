namespace Exercicio_2__02_12
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Yellow;
            this.botao1.Location = new System.Drawing.Point(115, 93);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(128, 52);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Amarelo";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Red;
            this.botao2.Location = new System.Drawing.Point(115, 181);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(123, 51);
            this.botao2.TabIndex = 1;
            this.botao2.Text = "Vermelho";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.AutoSize = true;
            this.mensagem1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem1.Location = new System.Drawing.Point(261, 148);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(92, 32);
            this.mensagem1.TabIndex = 2;
            this.mensagem1.Text = "label1";
            this.mensagem1.Click += new System.EventHandler(this.mensagem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label mensagem1;
    }
}

