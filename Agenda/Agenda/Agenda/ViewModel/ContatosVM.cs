using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    class ContatosVM : ViewModelBase
    {
        public ICommand AddCommand { get; set; }
        public ICommand CadastrarCommand { get; set; }
        private int i = 0;
        //  private List<Model.ContatoModel> _listaContatos;
        private int codigo;
        private string nome;
        private string sobrenome;
        private string apelido;
        private string email;
        private string telefone;
        private List<Model.ContatoModel> lista;
        //  public List<Model.ContatoModel> ListaContatos { get { return _listaContatos; } set { _listaContatos = value; Notify("ListaContatos"); } }
        public int Codigo { get { return codigo; } set { codigo = value; Notify("Codigo"); } }
        public string Nome { get { return nome; } set { nome = value; Notify("Nome"); } }
        public string Sobrenome { get { return sobrenome; } set { sobrenome = value; Notify("Sobrenome"); } }
        public string Apelido { get { return apelido; } set { apelido = value; Notify("Apelido"); } }
        public string Email { get { return email; } set { email = value; Notify("Email"); } }
        public string Telefone { get { return telefone; } set { telefone = value; Notify("Telefone"); } }

        public List<Model.ContatoModel> Lista { get { return lista; } set { lista = value; Notify("Lista"); } }

        public ContatosVM()
        {
            List<Model.ContatoModel> minhaLista = new List<Model.ContatoModel>();
            CadastrarCommand = new Command(Cadastrar);
            this.AddCommand = new Command(NavigateToCadastro);

            using (var dados = new DAO.ContatoDAO())
            {
                Lista = dados.Lista();
            }

        }

        public void NavigateToCadastro()
        {
            Agenda.App.Current.MainPage.Navigation.PushAsync(new View.CadastroView());
        }

        public void Cadastrar()
        {
            using (var dados = new DAO.ContatoDAO())
            {
                dados.Insert(new Model.ContatoModel { Codigo = this.Codigo, Nome = this.Nome, Sobrenome = this.Sobrenome, Apelido = this.Apelido, Email = this.Email, Telefone = this.telefone });
                
            }            
            Agenda.App.Current.MainPage.Navigation.PushAsync(new View.ContatosView());


        }
    }
}
