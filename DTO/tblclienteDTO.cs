using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJETOMVCB21.BLL;

namespace PROJETOMVCB21.DTO
{
    public class tblclienteDTO
    {
        private int id_cliente;
        private string nome_cliente, sobrenome_cliente,mae_nome,cpf_cliente;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome_cliente
        {

            set
            {
                if (value != string.Empty)
                    this.nome_cliente = value;


                else
                {

                    throw new Exception("O Campo nome é Obrigatorio");
                }

            }
            get { return this.nome_cliente; }
        }
        public string Cpf_cliente
        {

            set
            {
                if (value != string.Empty)
                    this.cpf_cliente = value;


                else
                {

                    throw new Exception("O Campo Cpf é Obrigatorio");
                }

            }
            get { return this.cpf_cliente; }
        }
        public string Mae_nome
        {

            set
            {
                if (value != string.Empty)
                    this.mae_nome = value;


                else
                {
                   
                    throw new Exception("O Campo 'Nome da mãe' é Obrigatorio");
                }

            }
            get { return this.mae_nome; }
        }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        
     
    }
}