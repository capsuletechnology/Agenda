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
        private ObservableCollection<Model.ContatoModel> _listaContatos;
        private int codigo;
        private string nome;
        private string sobrenome;
        private string apelido;
        private string email;
        private string telefone;

        public ObservableCollection<Model.ContatoModel> ListaContatos { get { return _listaContatos; } set { _listaContatos = value; Notify("ListaContatos"); } }
        public int Codigo { get { return codigo; } set { codigo = value; Notify("Codigo"); } }
        public string Nome { get { return nome; } set { nome = value; Notify("Nome"); } }
        public string Sobrenome { get { return sobrenome; } set { sobrenome = value; Notify("Sobrenome"); } }
        public string Apelido { get { return apelido; } set { apelido = value; Notify("Apelido"); } }
        public string Email { get { return email; } set { email = value; Notify("Email"); } }
        public string Telefone { get { return telefone; } set { telefone = value; Notify("Telefone"); } }


        public ContatosVM()
        {
            this.AddCommand = new Command(NavigateToCadastro);
        }

        public void NavigateToCadastro()
        {
            _listaContatos = new ObservableCollection<Model.ContatoModel>();
            Agenda.App.Current.MainPage.Navigation.PushAsync(new View.CadastroView());
        }

    }
}
