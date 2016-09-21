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
        private List<Model.ContatoModel> lista;
        public List<Model.ContatoModel> Lista { get { return lista; } set { lista = value; Notify("Lista"); } }

        public ContatosVM()
        {
            Lista = new List<Model.ContatoModel>();
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
    }
}
