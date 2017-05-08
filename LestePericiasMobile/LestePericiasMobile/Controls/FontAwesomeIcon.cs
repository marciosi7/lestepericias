using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LestePericiasMobile.Controls
{
    public class FontAwesomeIcon : Label
    {
        //Must match the exact "Name" of the font which you can get by double clicking the TTF in Windows
        public const string Typeface = "FontAwesome";

        //Constructor for XAML use
        //<local:FontAwesomeIcon Text="{x:Static local:FontAwesomeIcon.Icon.Gear}"></local:FontAwesomeIcon>
        public FontAwesomeIcon()
        {
            FontFamily = Typeface;
        }

        public FontAwesomeIcon(string fontAwesomeIcon = null)
        {
            FontFamily = Typeface;    //iOS is happy with this, Android needs a renderer to add ".ttf"
            Text = fontAwesomeIcon;
        }

        /// <summary>
        /// Get more icons from https://github.com/neilkennedy/FontAwesome.Xamarin/blob/master/FontAwesome.Xamarin/FontAwesome.cs
        /// </summary>
        public static class Icon
        {
            public static string Search = "\uf002";
            public static string Plus = "\uf067";
        }
    }
}
