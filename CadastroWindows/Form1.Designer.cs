namespace CadastroWindows
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(26, 42);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(49, 20);
            this.tb_cod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(26, 81);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(314, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(26, 120);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(131, 20);
            this.tb_cpf.TabIndex = 4;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(26, 159);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(131, 20);
            this.tb_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(26, 202);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(131, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_visualizar);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 38);
            this.panel1.TabIndex = 10;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(26, 3);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(265, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(144, 3);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_visualizar.TabIndex = 2;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_visualizar;
    }
}

