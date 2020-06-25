using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJETOMVCB21.DAL;
using System.Data;




namespace PROJETOMVCB21.BLL
{ 
    public class tblclienteBLL
        
    {
        private DALmysql daoBanco = new DALmysql();
        public Boolean Autenticar(string cpf, string nome,string nomemae)
        {
            string consulta = string.Format($@"select * from tbl_clientes where cpf_cliente = '{cpf}' and  nome_cliente = '{nome}' and mae_nome='{nomemae}' ;");
             DataTable dt =  daoBanco.executarconsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}