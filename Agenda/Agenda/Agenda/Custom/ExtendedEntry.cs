using System;
using Xamarin.Forms;

namespace Agenda.Custom
{
	public class ExtendedEntry : Entry
	{
		public static readonly BindableProperty FontProperty =
					BindableProperty.Create("Font", typeof(Font),
					typeof(ExtendedEntry), new Font());

		public Font Font
		{
			get { return (Font)GetValue(FontProperty); }
			set { SetValue(FontProperty, value); }
		}
	}
}
