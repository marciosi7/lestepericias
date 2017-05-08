using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using LestePericiasMobile.Droid.Renderer;
using Android.Graphics;
using LestePericiasMobile.Controls;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(AwesomeRenderer))]
namespace LestePericiasMobile.Droid.Renderer
{
    
        public class AwesomeRenderer : LabelRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
            {
                base.OnElementChanged(e);
                if (e.OldElement == null)
                {
                    //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                    Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, FontAwesomeIcon.Typeface + ".ttf");
                }
            }
        }
}