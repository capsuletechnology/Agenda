using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agenda.View
{
	public partial class ContatosView : ContentPage
	{
		public ContatosView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModel.ContatosVM();

            ListaContatos.ItemTapped += async (sender, e) =>
            {
                var contato = e.Item as Model.ContatoModel;
                //await MVVM.App.Current.MainPage.Navigation.PushAsync(new View.Autor(livro.Id));
                await Agenda.App.Current.MainPage.Navigation.PushAsync(new View.InfoView(contato));
            };

        }

        public void CommandAdd(EventArgs e, Object o)
        {
            Agenda.App.Current.MainPage.Navigation.PushAsync(new View.CadastroView());
        }

    }
}
