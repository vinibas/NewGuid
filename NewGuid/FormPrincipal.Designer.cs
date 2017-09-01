namespace NewGuid
{
    partial class FormPrincipal
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
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnGerarNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGuid
            // 
            this.txtGuid.Enabled = false;
            this.txtGuid.Location = new System.Drawing.Point(12, 12);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(294, 20);
            this.txtGuid.TabIndex = 0;
            this.txtGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(12, 38);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(94, 23);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "Copiar (C)";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnGerarNovo
            // 
            this.btnGerarNovo.Location = new System.Drawing.Point(112, 38);
            this.btnGerarNovo.Name = "btnGerarNovo";
            this.btnGerarNovo.Size = new System.Drawing.Size(94, 23);
            this.btnGerarNovo.TabIndex = 2;
            this.btnGerarNovo.Text = "Gerar novo (N)";
            this.btnGerarNovo.UseVisualStyleBackColor = true;
            this.btnGerarNovo.Click += new System.EventHandler(this.btnGerarNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(212, 38);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar (F)";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 73);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGerarNovo);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtGuid);
            this.KeyPreview = true;
            this.Name = "FormPrincipal";
            this.Text = "NewGuid - Gerador de Guid";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnGerarNovo;
        private System.Windows.Forms.Button btnFechar;
    }
}

