using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ListView), typeof(Balln.iOS.Renderers.CustomListViewRenderer))]
namespace Balln.iOS.Renderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
            base.OnElementChanged(e);
            Control.AllowsSelection = false;
		}
	}
}
