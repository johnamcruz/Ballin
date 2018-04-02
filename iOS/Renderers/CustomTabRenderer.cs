using System;
using Balln.Constants;
using Balln.iOS.Extensions;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(Balln.iOS.Renderers.CustomTabRenderer))]
namespace Balln.iOS.Renderers
{
    public class CustomTabRenderer : TabbedRenderer
    {
        const int MaxTabItems = 3;

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var size = new CoreGraphics.CGSize(TabBar.Frame.Width / MaxTabItems, TabBar.Frame.Height);
            UITabBar.Appearance.SelectionIndicatorImage = new UIImage().MakeImageWithColorAndSize(Colors.DarkGreen.ToUIColor(), size);

            foreach (var item in TabBar?.Items)
            {
                item.Image = item.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            }
        }
    }
}
