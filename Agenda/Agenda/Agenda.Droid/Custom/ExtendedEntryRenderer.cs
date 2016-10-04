using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(Agenda.Custom.ExtendedEntry), typeof(Agenda.Droid.Custom.ExtendedEntryRenderer))]
namespace Agenda.Droid.Custom
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			var view = (Agenda.Custom.ExtendedEntry)Element;
			SetFont(view);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			var view = (Agenda.Custom.ExtendedEntry)Element;

			if (string.IsNullOrEmpty(e.PropertyName) ||
				e.PropertyName == "Typeface")
				SetFont(view);
		}

		private void SetFont(Agenda.Custom.ExtendedEntry view)
		{
			Typeface uiFont;
			if (view.Font != Font.Default &&
				(uiFont = view.Font.ToTypeface()) != null)
				Control.Typeface = uiFont;
			else if (view.Font == Font.Default)
				Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/waltographUI.ttf");
			Control.SetTextSize(ComplexUnitType.Sp, 18);
		}
	}
}
