using System;
using CoreGraphics;
using UIKit;

namespace Balln.iOS.Extensions
{
    public static class ImageExtensions
    {
        public static UIImage MakeImageWithColorAndSize(this UIImage image, UIColor color, CGSize size)
        {
            UIGraphics.BeginImageContextWithOptions(size, false, 0);
            color.SetFill();
            UIGraphics.RectFill(new CGRect(0, 0, size.Width, size.Height));
            var img = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return img;
        }
    }
}
