namespace OS_35
{
    partial class Frmlogin
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(141, 85);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(249, 20);
            this.txt_senha.TabIndex = 15;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(38, 86);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(46, 16);
            this.lbl_senha.TabIndex = 14;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(141, 29);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(249, 20);
            this.txt_usuario.TabIndex = 17;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(38, 30);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(54, 16);
            this.lbl_usuario.TabIndex = 16;
            this.lbl_usuario.Text = "Usuário";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(36, 171);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(145, 52);
            this.btn_entrar.TabIndex = 18;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(225, 171);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(145, 52);
            this.btn_sair.TabIndex = 19;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 279);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmlogin";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
    }
}