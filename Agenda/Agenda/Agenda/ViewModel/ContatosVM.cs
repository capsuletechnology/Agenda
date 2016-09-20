using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    class ContatosVM
    {
        public ICommand AddCommand { get; set; }

        public ContatosVM()
        {
            this.AddCommand = new Command(NavigateToCadastro);
        }

        public void NavigateToCadastro()
        {
            Agenda.App.Current.MainPage.Navigation.PushAsync(new View.CadastroView());
        }

    }
}
