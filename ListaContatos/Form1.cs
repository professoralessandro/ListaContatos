using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContatos
{
    public partial class Form1 : Form
    {

        private ListaTelefonica ListaCont;
        public Form1()
        {
            InitializeComponent();
            ListaCont = new ListaTelefonica();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            if(ListaCont.gravar(new Contato(Convert.ToInt32(textId.Text), textNome.Text, textEmail.Text, textTelefone.Text))==true)
            {
                MessageBox.Show("O novo contato foi gravado com sucesso");

                textId.Text = "";
                textNome.Text = "";
                textEmail.Text = "";
                textTelefone.Text = "";
                listBoxBuscar.Items.Clear();
            }
            else
            {
                MessageBox.Show("O contato foi substituido com sucesso");

                textId.Text = "";
                textNome.Text = "";
                textEmail.Text = "";
                textTelefone.Text = "";
                listBoxBuscar.Items.Clear();
            }
            

            /* if(ListaCont.adicionar(Convert.ToInt32(textId.Text), textNome.Text, textEmail.Text, textTelefone.Text))
             {
                 textId.Text = "";
                 textNome.Text = "";
                 textEmail.Text = "";
                 textTelefone.Text = "";
             }
             else
             {
                 MessageBox.Show("Erro ao incluir este contato /n Tente novamente");
             }*/

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if(ListaCont.remover(new Contato(Convert.ToInt32(textId.Text))) == true)
            {
                MessageBox.Show("O contato foi deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao deletar o contato");
                
            }
            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            textTelefone.Text = "";
            listBoxBuscar.Items.Clear();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBoxBuscar.Items.Clear();
            foreach (Contato contatinho in ListaCont.MinhaLista)
            {
                listBoxBuscar.Items.Add(contatinho.dados());
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O formulário foi limpo");

            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            textTelefone.Text = "";
            listBoxBuscar.Items.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            /*
            int c = Convert.ToInt16(textId.Text);

            foreach (Contato ctt in ListaCont.MinhaLista)
            {
                if (ctt.Equals(c)) return ctt;
            }
            return null;*/


            //Convert.ToInt32(textId.Text, Convert.ToString(textNome.Text), textEmail.Text, textTelefone.Text) = ListaCont.pesquisar(new Contato(Convert.ToInt32(textId.Text)));
        }
    }//class
}//namespace
