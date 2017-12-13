using MyBuddy;
using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyBuddy
{
    public partial class App : Application
    {
        static dbMyBuddy database;

        public App()
        {
            InitializeComponent();
            MainPage=new Register();
        }

        public static dbMyBuddy Database
        {
            get
            {
                if (database == null)
                {
                    database = new dbMyBuddy(DependencyService.Get<IFileHelper>().GetLocalFilePath("myBuddySQLite.db3"));
                }
                return database;
            }
        }
    }
}