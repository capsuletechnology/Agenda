using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agenda.View
{
	public partial class InfoView : ContentPage
	{
		 Model.ContatoModel contato;

		public InfoView(Model.ContatoModel contato)
		{
			InitializeComponent();
			AlimentarContatos(contato);
			this.contato = contato;

		}

		public void AlimentarContatos(Model.ContatoModel contato)
		{
			string nome;
			nome = contato.Nome + " '" + contato.Apelido + "' " + contato.Sobrenome;
			this.Title = contato.Nome;
			Email.Text = contato.Email;
			Telefone.Text = contato.Telefone;
			NomeCompleto.Text = nome;
			PrimeiraLetra.Text = contato.Nome.Substring(0, 1);
			Rua1.Text = contato.Enderecos[0].Rua;
			Numero1.Text = contato.Enderecos[0].Numero;
			Logradouro1.Text = contato.Enderecos[0].Logradouro;
			Rua2.Text = contato.Enderecos[1].Rua;
			Numero2.Text = contato.Enderecos[1].Numero;
			Logradouro2.Text = contato.Enderecos[1].Logradouro;
		}

		public void ApagarContato(object sender, EventArgs e)
		{

			using (var dados = new DAO.ContatoDAO())
			{
				dados.Delete(this.contato);
			}
			Agenda.App.Current.MainPage.Navigation.PushAsync(new View.ContatosView());
		}

		public void EditarContato(Object o, EventArgs e)
		{
			Agenda.App.Current.MainPage.Navigation.PushAsync(new View.EditarView(contato));
		}

	}
}
