using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Anime_List_App.Core.ExtensionClasses
{
    public static class SourceInitializer
    {
        /// <summary>
        /// Sets the image path (Source)
        /// </summary>
        public static void SetIconSource(this ISourceInitializer _, Dictionary<Image, string> items)
        {
            foreach (var item in items)
            {
                item.Key.Source = new BitmapImage(
                    new Uri($"{LocalPath.IconsPath}{item.Value}.png"));
            }
        }
    }
}
