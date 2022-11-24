namespace projeto_uninove
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
            this.idbNome = new System.Windows.Forms.Label();
            this.idbSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btBoasVindasaolavarapido = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idbNome
            // 
            this.idbNome.AutoSize = true;
            this.idbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbNome.Location = new System.Drawing.Point(146, 82);
            this.idbNome.Name = "idbNome";
            this.idbNome.Size = new System.Drawing.Size(85, 29);
            this.idbNome.TabIndex = 0;
            this.idbNome.Text = "Nome:";
            // 
            // idbSobrenome
            // 
            this.idbSobrenome.AutoSize = true;
            this.idbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbSobrenome.Location = new System.Drawing.Point(85, 151);
            this.idbSobrenome.Name = "idbSobrenome";
            this.idbSobrenome.Size = new System.Drawing.Size(146, 29);
            this.idbSobrenome.TabIndex = 1;
            this.idbSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(248, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 34);
            this.txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(248, 151);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(185, 34);
            this.txtSobrenome.TabIndex = 3;
            // 
            // btBoasVindasaolavarapido
            // 
            this.btBoasVindasaolavarapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoasVindasaolavarapido.Location = new System.Drawing.Point(90, 217);
            this.btBoasVindasaolavarapido.Name = "btBoasVindasaolavarapido";
            this.btBoasVindasaolavarapido.Size = new System.Drawing.Size(389, 56);
            this.btBoasVindasaolavarapido.TabIndex = 4;
            this.btBoasVindasaolavarapido.Text = "Dar boas Vindas ao lava rápido";
            this.btBoasVindasaolavarapido.UseVisualStyleBackColor = true;
            this.btBoasVindasaolavarapido.Click += new System.EventHandler(this.btBoasVindasaolavarapido_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(85, 318);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(45, 29);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "----";
            this.lbResultado.Click += new System.EventHandler(this.ibResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btBoasVindasaolavarapido);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.idbSobrenome);
            this.Controls.Add(this.idbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idbNome;
        private System.Windows.Forms.Label idbSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btBoasVindasaolavarapido;
        private System.Windows.Forms.Label lbResultado;
    }
}

