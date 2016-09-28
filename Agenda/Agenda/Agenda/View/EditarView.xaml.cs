using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Agenda.View
{
	public partial class EditarView : ContentPage
	{
		Model.ContatoModel contato;

		public EditarView(Model.ContatoModel contato)
		{
			InitializeComponent();
			this.contato = contato;
			PreencherCampos();
		}

		public void PreencherCampos()
		{
			this.Nome.Text = contato.Nome;
			this.Sobrenome.Text = contato.Sobrenome;
			this.Apelido.Text = contato.Apelido;
			this.Telefone.Text = contato.Telefone;
			this.Email.Text = contato.Email;
			this.Rua1.Text = contato.Enderecos[0].Rua;
			this.N1.Text = contato.Enderecos[0].Numero;
			this.Logradouro1.Text = contato.Enderecos[0].Logradouro;
			this.Rua2.Text = contato.Enderecos[1].Rua;
			this.N2.Text = contato.Enderecos[1].Numero;
			this.Logradouro2.Text = contato.Enderecos[1].Logradouro;
		
		}

		public void Atualizar(object sender, EventArgs e)
		{

			this.contato.Nome = this.Nome.Text;
			this.contato.Sobrenome = this.Sobrenome.Text;
			this.contato.Apelido = this.Apelido.Text;
			this.contato.Telefone = this.Telefone.Text;
			this.contato.Email = this.Email.Text;
			this.contato.Enderecos[0].Rua = this.Rua1.Text;
			this.contato.Enderecos[0].Numero = this.N1.Text;
			this.contato.Enderecos[0].Logradouro = this.Logradouro1.Text;
			this.contato.Enderecos[1].Rua = this.Rua2.Text;
			this.contato.Enderecos[1].Numero = this.N2.Text;
			this.contato.Enderecos[1].Logradouro = this.Logradouro2.Text;

			using (var dados = new DAO.ContatoDAO())
			{
				dados.Update(this.contato);

			}

			using (var dados = new DAO.EnderecoDAO())
			{
				dados.Update(this.contato.Enderecos[1]);

			}

			Agenda.App.Current.MainPage.Navigation.PushAsync(new View.ContatosView());
		}


	}
}
