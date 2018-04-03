using System;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(Balln.iOS.Renderers.ContentPageRenderer))]
namespace Balln.iOS.Renderers
{
    public class ContentPageRenderer : PageRenderer
    {
        bool toolbarLoaded;

        public new ContentPage Element
        {
            get { return base.Element as ContentPage; }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (!toolbarLoaded)
            {
                var leftNavigationList = new List<UIBarButtonItem>();
                var rightNavigationList = new List<UIBarButtonItem>();

                if (NavigationController == null || NavigationController.TopViewController == null) return;

                var navigationItem = this.NavigationController.TopViewController.NavigationItem;

                for (var index = 0; index < Element.ToolbarItems.Count; index++)
                {

                    var reorder = (Element.ToolbarItems.Count - 1);
                    var ItemPriority = Element.ToolbarItems[reorder - index].Priority;


                    if (ItemPriority == 1)
                    {
                        var LeftNavItems = navigationItem.RightBarButtonItems[index];
                        leftNavigationList.Add(LeftNavItems);

                    }
                    else if (ItemPriority == 0)
                    {
                        var RightNavItems = navigationItem.RightBarButtonItems[index];
                        rightNavigationList.Add(RightNavItems);
                    }

                    toolbarLoaded = true;
                }

                navigationItem.SetLeftBarButtonItems(leftNavigationList.ToArray(), false);
                navigationItem.SetRightBarButtonItems(rightNavigationList.ToArray(), false);
            }
        }
    }
}
