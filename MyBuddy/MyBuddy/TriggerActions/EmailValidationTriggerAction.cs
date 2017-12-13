using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyBuddy
{
    public class EmailValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(entry.Text);
            if (match.Success)
            {
                entry.TextColor = Color.Black;
            }else
            {
                entry.TextColor = Color.Red;
            }
        }
    }
}
