using System;
using System.IO;
using System.Windows.Media.Imaging;
using static Launcher8.Misc.Image;

namespace Launcher8.Misc
{
    /// <summary>
    /// Provides the ability to load an image from inside the project.
    /// </summary>
    internal class ImageUtilities
    {
        internal static BitmapImage GetBitmapImage(Images image, Extensions extension, Themes themes)
        {
            return new BitmapImage(BuildImageUri(image, extension, themes));
        }
        private static Uri BuildImageUri(Images image, Extensions extension, Themes themes)
        {
            return BuildPackUri(Path.Join("/Resources", "Images", $"{themes}", $"{Image.GetImage(image)}.{extension.ToString().ToLowerInvariant()}"));
        }
        private static Uri BuildPackUri(String postFix)
        {
            return new Uri(Path.Join("pack://application:,,,", postFix));
        }
    }
}
