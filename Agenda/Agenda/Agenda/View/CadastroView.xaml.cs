using System;
using System.Collections.Generic;
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
            BindingContext = new ViewModel.CadastroVM();
            this.Title = "Novo Contato";
            this.BackgroundColor = Color.FromHex("#ecf0f1");
		}
	}
}
