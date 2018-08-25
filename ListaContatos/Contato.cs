using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContatos
{
    class Contato
    {
        #region Atributos
        private int id;
        private string email;
        private string nome;
        private string telefone;
        #endregion

        #region Propriedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        #endregion

        #region Construtores
        public Contato(int id, string nome, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public Contato(int id)
        {
            this.id = id;
        }

        public Contato()
            : this(0, "", "", "")
        {
        }
        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Contato p = (Contato)obj;
            return this.id.Equals(p.id);
        }
        #endregion

        #region MetodosFuncionais
        public string dados()
        {
            return "id : " + this.id.ToString() + " - nome: " + this.nome + " - email: " +
                this.email + " - telefone: " + this.telefone ;
        }
        public string buscaDados(int i)
        {
            return "id : " + this.id.ToString() + " - nome: " + this.nome + " - email: " +
                this.email + " - telefone: " + this.telefone;
        }
    /*
    public double precoTotal();
    {

    }*/
    #endregion
}
}
