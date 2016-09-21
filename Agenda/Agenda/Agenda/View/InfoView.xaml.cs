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
        public InfoView(Model.ContatoModel contato)
        {
            InitializeComponent();
            AlimentarContatos(contato);

        }

        public void AlimentarContatos(Model.ContatoModel contato)
        {
            this.Title = contato.Nome;
            Email.Text = contato.Telefone;


        }

    }
}
