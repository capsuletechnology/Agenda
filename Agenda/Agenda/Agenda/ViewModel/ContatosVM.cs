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
		//  private List<Model.ContatoModel> _listaContatos;
		private int codigo;
		private string nome;
		private string sobrenome;
		private string apelido;
		private string email;
		private string telefone;
		private string rua1;
		private string numero1;
		private string logradouro1;
		private string rua2;
		private string numero2;
		private string logradouro2;
		private List<Model.ContatoModel> lista;
		private List<Model.Endereco> enderecos;
		//  public List<Model.ContatoModel> ListaContatos { get { return _listaContatos; } set { _listaContatos = value; Notify("ListaContatos"); } }
		public int Codigo { get { return codigo; } set { codigo = value; Notify("Codigo"); } }
		public string Nome { get { return nome; } set { nome = value; Notify("Nome"); } }
		public string Sobrenome { get { return sobrenome; } set { sobrenome = value; Notify("Sobrenome"); } }
		public string Apelido { get { return apelido; } set { apelido = value; Notify("Apelido"); } }
		public string Email { get { return email; } set { email = value; Notify("Email"); } }
		public string Telefone { get { return telefone; } set { telefone = value; Notify("Telefone"); } }
		public string Rua1 { get { return rua1; } set { rua1 = value; Notify("Rua1"); } }
		public string Numero1 { get { return numero1; } set { numero1 = value; Notify("Numero1"); } }
		public string Logradouro1 { get { return logradouro1; } set { logradouro1 = value; Notify("Logradouro1"); } }
		public string Rua2 { get { return rua2; } set { rua2 = value; Notify("Rua2"); } }
		public string Numero2 { get { return numero2; } set { numero2 = value; Notify("Numero2"); } }
		public string Logradouro2 { get { return logradouro2; } set { logradouro2 = value; Notify("Logradouro2"); } }


		public List<Model.ContatoModel> Lista { get { return lista; } set { lista = value; Notify("Lista"); } }
		public List<Model.Endereco> Enderecos { get { return enderecos; } set { enderecos = value; Notify("Enderecos"); } }

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
			this.Enderecos = new List<Model.Endereco>();
			this.Enderecos.Add(new Model.Endereco { Rua = this.Rua1, Numero = this.Numero1, Logradouro = this.logradouro1 });
			this.Enderecos.Add(new Model.Endereco { Rua = this.Rua2, Numero = this.Numero2, Logradouro = this.logradouro2 });


			using (var dados = new DAO.ContatoDAO())
			 {
				dados.Insert(new Model.ContatoModel { Codigo = this.Codigo, Nome = this.Nome, Sobrenome = this.Sobrenome, Apelido = this.Apelido, Email = this.Email, Telefone = this.Telefone, Enderecos = this.Enderecos });

			}
			Agenda.App.Current.MainPage.Navigation.PushAsync(new View.ContatosView());


		}
	}
}
