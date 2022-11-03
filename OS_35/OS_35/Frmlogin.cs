using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_35.BLL;

namespace OS_35
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        BLL_login login = new BLL_login();

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(login.logar(txt_usuario.Text,txt_senha.Text) == "Usuario")
            {
                FrmUsuario usuario = new FrmUsuario();
                usuario.ShowDialog();
            }else if(login.logar(txt_usuario.Text, txt_senha.Text) == "Tecnico")
            {
                FrmTecnico tecnico = new FrmTecnico();
                tecnico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
    }
}
