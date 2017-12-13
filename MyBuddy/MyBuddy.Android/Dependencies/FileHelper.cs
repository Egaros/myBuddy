using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;
using MyBuddy.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace MyBuddy.Droid
{ 
public class FileHelper : IFileHelper
  {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}