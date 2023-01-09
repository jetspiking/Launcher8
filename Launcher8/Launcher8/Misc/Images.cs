using System;

namespace Launcher8.Misc
{
    /// <summary>
    /// Provides a list of images that can be used in this project.
    /// 
    /// </summary>
    public class Image
    {
        private const String AppbarTilesNine = "appbar.tiles.nine";

        public static String? GetImage(Images image)
        {
            switch (image)
            {
                case Images.AppbarTilesNine:
                    return AppbarTilesNine;
            }
            return null;
        }

        public enum Images
        {
            AppbarTilesNine
        }
    }
}
