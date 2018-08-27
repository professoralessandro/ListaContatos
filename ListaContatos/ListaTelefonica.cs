using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContatos
{
    class ListaTelefonica
    {
        private List<Contato> minhaLista;

        public List<Contato> MinhaLista
        {
            get { return minhaLista; }
        }

        public ListaTelefonica()
        {
            this.minhaLista = new List<Contato>();
        }

        public void adicionar(Contato p)
        {
            this.minhaLista.Add(p);
        }

        public bool gravar(Contato p)
        {
            bool a = false;

            if(this.minhaLista.IndexOf(p) == -1)
            {
                this.minhaLista.Add(p);
                return a = true;
            }
            else
            {
                this.minhaLista.Remove(p);
                this.minhaLista.Add(p);
                return a = false;
            }

        }

        public int pesquisar(Contato p)
        {
                return this.minhaLista.IndexOf(p);
        }

        public bool remover(Contato p)
        {
            return this.minhaLista.Remove(p);
        }
        
        public Boolean isEmpty(bool a)
        {
            return a;
        }
    }
}
