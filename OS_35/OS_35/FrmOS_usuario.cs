﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_35.BLL;
using OS_35.DTO;

namespace OS_35
{
    public partial class FrmOS_usuario : Form
    {
        public FrmOS_usuario()
        {
            InitializeComponent();
        }

        DTO_OS dto_os = new DTO_OS();
        BLL_OS bll_os = new BLL_OS();
        BLL_tecnico bll_tecnico = new BLL_tecnico();
        BLL_login bll_login = new BLL_login();

        public void Carregar_GRID()
        {
            try
            {
                dto_os.Usuario = bll_login.ID_Usuario();
                dgv_view.DataSource = bll_os.Listar_OS_Usuario(dto_os);
                cbx_tecnico.DataSource = bll_tecnico.Consultar_Tabela();
                cbx_tecnico.DisplayMember = "nome";
                cbx_tecnico.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Descricao = txt_descricao.Text;
                dto_os.Status_os = "EM ABERTO";
                dto_os.Tecnico = int.Parse(cbx_tecnico.SelectedValue.ToString());
                dto_os.Usuario = bll_login.ID_Usuario();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
