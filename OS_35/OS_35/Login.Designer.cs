namespace OS_35
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.lbl_senha);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Location = new System.Drawing.Point(73, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 367);
            this.panel1.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(371, 258);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(171, 63);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Cancelar";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(128, 258);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(169, 63);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "LogIn";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(212, 172);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(328, 22);
            this.txt_senha.TabIndex = 3;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(212, 75);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(328, 22);
            this.txt_usuario.TabIndex = 2;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(73, 172);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(73, 73);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(71, 20);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuário";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_entrar;
    }
}