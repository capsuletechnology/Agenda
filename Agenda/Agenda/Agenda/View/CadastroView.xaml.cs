using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agenda.View
{
	public partial class CadastroView : ContentPage
	{
		public CadastroView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModel.ContatosVM();
            this.Title = "Novo Contato";
            this.BackgroundColor = Color.FromHex("#ecf0f1");
		}
	}
}
