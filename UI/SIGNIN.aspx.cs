using System;
using PROJETOMVCB21.BLL;
using PROJETOMVCB21.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJETOMVCB21.UI
{
    public partial class SIGNIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                tblclienteDTO cliente = new tblclienteDTO();
                cliente.Cpf_cliente = txtcpfb21.Text;
                cliente.Nome_cliente = txtnomeb21.Text;
                cliente.Mae_nome = txtnomemaeb21.Text;

                tblclienteBLL bllcliente = new tblclienteBLL();
                if (bllcliente.Autenticar(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Mae_nome))
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Localizado no Banco de dados.Processo em Análise";


                }
                else

                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }

            }catch(Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }

        }
    }
}