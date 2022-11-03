using System;
using OS_35.DAL;
using System.Data;

namespace OS_35.BLL
{
    internal class BLL_especialidade
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable Consultar_Tabela()
        {
            try
            {
                return bd.ConsultarTabelas("select * from especialidade");
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
