using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio2
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Pessoas();           
        }

        protected void Menu1_MenuItemClick(Object sender,
      System.Web.UI.WebControls.MenuEventArgs e)
        {



            switch (e.Item.Value)
            {
                case "Andamento":
                    SituacaoAndamento();
                      return;
               case "Atrasada":
                 SituacaoAtrasado();
                return;
        }
        }
        public void Pessoas()
{
    var pessoas = new List<Pessoa>();
    pessoas.Add(new Pessoa() { Nome = "David Koch ", Email = "david@gmail.com", Situacao = "em andamento" });
    pessoas.Add(new Pessoa() { Nome = "Charles Koch", Email = "koch@gmail.com", Situacao = "atrasado" });
    pessoas.Add(new Pessoa() { Nome = "Michael Bloomberg", Email = "bloomberg@gmail.com", Situacao = "atrasado" });
    pessoas.Add(new Pessoa() { Nome = "Larry Ellison", Email = "larry@gmail.com", Situacao = "atrasado" });
    pessoas.Add(new Pessoa() { Nome = "Mark Zuckerberg", Email = "mark@gmail.com", Situacao = "atrasado" });
    pessoas.Add(new Pessoa() { Nome = "Jeff Bezos", Email = "jeff@gmail.com", Situacao = "em andamento" });
    pessoas.Add(new Pessoa() { Nome = "Carlos Slim", Email = "carlos@gmail.com", Situacao = "em andamento" });
    pessoas.Add(new Pessoa() { Nome = "Warren Buffett", Email = "warren@gmail.com", Situacao = "atrasado" });
    pessoas.Add(new Pessoa() { Nome = "Amâncio Ortega", Email = "ortega@gmail.com", Situacao = "em andamento" });
    pessoas.Add(new Pessoa() { Nome = "Bill Gates", Email = "gates@gmail.com", Situacao = "em andamento" });
    GridPessoas.DataSource = pessoas;
    GridPessoas.DataBind();
}

        public void SituacaoAtrasado()
        {
            var novaListaPessoas = new List<Pessoa>();
            novaListaPessoas.Add(new Pessoa() { Nome = "David Koch ", Email = "david@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Charles Koch", Email = "koch@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Michael Bloomberg", Email = "bloomberg@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Larry Ellison", Email = "larry@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Mark Zuckerberg", Email = "mark@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Jeff Bezos", Email = "jeff@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Carlos Slim", Email = "carlos@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Warren Buffett", Email = "warren@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Amâncio Ortega", Email = "ortega@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Bill Gates", Email = "gates@gmail.com", Situacao = "em andamento" });
            List<Pessoa> listaPessoaSelecionada =
            (from Pessoa p in novaListaPessoas
             where p.Situacao == "atrasado"
             select p).ToList();

            GridPessoas.DataSource = listaPessoaSelecionada;
            GridPessoas.DataBind();
        }

        
        public void SituacaoAndamento()
        {
            var novaListaPessoas = new List<Pessoa>();
            novaListaPessoas.Add(new Pessoa() { Nome = "David Koch ", Email = "david@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Charles Koch", Email = "koch@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Michael Bloomberg", Email = "bloomberg@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Larry Ellison", Email = "larry@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Mark Zuckerberg", Email = "mark@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Jeff Bezos", Email = "jeff@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Carlos Slim", Email = "carlos@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Warren Buffett", Email = "warren@gmail.com", Situacao = "atrasado" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Amâncio Ortega", Email = "ortega@gmail.com", Situacao = "em andamento" });
            novaListaPessoas.Add(new Pessoa() { Nome = "Bill Gates", Email = "gates@gmail.com", Situacao = "em andamento" });
            List<Pessoa> listaPessoaSelecionada =
            (from Pessoa p in novaListaPessoas
             where p.Situacao == "em andamento"
             select p).ToList();

            GridPessoas.DataSource = listaPessoaSelecionada;
            GridPessoas.DataBind();
        }

          }
}