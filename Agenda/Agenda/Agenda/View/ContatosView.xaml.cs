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
            this.BindingContext = new ViewModel.ContatosVM();
        }

    }
}
