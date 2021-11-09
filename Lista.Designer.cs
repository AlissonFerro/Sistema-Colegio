namespace WindowsFormsApp1
{
    partial class Lista
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnListarResp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(73, 54);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(440, 157);
            this.listBox.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnListar.Location = new System.Drawing.Point(73, 237);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Aluno";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnListarResp
            // 
            this.btnListarResp.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnListarResp.Location = new System.Drawing.Point(182, 236);
            this.btnListarResp.Name = "btnListarResp";
            this.btnListarResp.Size = new System.Drawing.Size(150, 23);
            this.btnListarResp.TabIndex = 2;
            this.btnListarResp.Text = "Listar Responsável";
            this.btnListarResp.UseVisualStyleBackColor = true;
            this.btnListarResp.Click += new System.EventHandler(this.btnListarResp_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.button1.Location = new System.Drawing.Point(437, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarResp);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listBox);
            this.Name = "Lista";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnListarResp;
        private System.Windows.Forms.Button button1;
    }
}



