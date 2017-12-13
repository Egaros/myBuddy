using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MyBuddy;
using MyBuddy.Droid.Effects;

[assembly: ResolutionGroupName("MyBuddy")]
[assembly: ExportEffect(typeof(EntryEffect), "EntryEffect")]
namespace MyBuddy.Droid.Effects
{
    public class EntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            SetBorder();
        }

        protected override void OnDetached()
        {
        }

        void SetBorder()
        {
            Control.SetBackgroundResource(Resource.Drawable.entryBorder);
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == BEntryEffect.HasBorderProperty.PropertyName)
                SetBorder();
        }
    }
}