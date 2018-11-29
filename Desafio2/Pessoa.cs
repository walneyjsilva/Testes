using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio2
{
    public class Pessoa
    {
        private string nome;
        private string email;
        private string situacao;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}