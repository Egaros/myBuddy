using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyBuddy
{
    public static class BEntryEffect 
    {
        public static readonly BindableProperty HasBorderProperty =
     BindableProperty.CreateAttached("HasBorder", typeof(bool), typeof(BEntryEffect), false, propertyChanged: OnHasBorderChanged);

        public static bool GetHasBorder(BindableObject view)
        {
            return (bool)view.GetValue(HasBorderProperty);
        }

        public static void SetHasBorder(BindableObject view, bool value)
        {
            view.SetValue(HasBorderProperty, value);
        }

        static void OnHasBorderChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
            {
                return;
            }

            bool hasBorder = (bool)newValue;
            if (hasBorder)
            {
                view.Effects.Add(new EntryEffect());
            }
            else
            {
                var toRemove = view.Effects.FirstOrDefault(e => e is EntryEffect);
                if (toRemove != null)
                {
                    view.Effects.Remove(toRemove);
                }
            }
        }

        class EntryEffect : RoutingEffect
        {
            public EntryEffect() : base("MyBuddy.EntryEffect")
            {
            }
        }
    }
}
