using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyBuddy
{
   public class RegisterViewModel : BaseViewModel
    {
        bool _isPassword = true;
        User _user = new User();
        string _passwordImage = "view.png";
        public Command OnShowHidePassword { get; set; }
        public Command OnRegisterUser { get; set; }
        public string PasswordImage { get { return _passwordImage; } set { SetProperty(ref _passwordImage, value); } }
        public bool IsPassword { get { return _isPassword; } set { SetProperty(ref _isPassword, value); } }
        public User User { get { return _user; } set { SetProperty(ref _user, value); } }

        private ImageSource picture;
        public ImageSource Picture{ get{ return this.picture; } set {if (Equals(value, this.picture)){return;} this.picture = value;OnPropertyChanged(); }}
        public ICommand TakePicture { get; set; }
        private ICameraProvider cameraProvider;


        public RegisterViewModel(INavigation navigation)
        {
            Navigation = navigation;
            RegisterCommands();
        }

        void RegisterCommands()
        {
            OnShowHidePassword = new Command(ShowHidePassword);
            OnRegisterUser = new Command(RegisterUser);
            cameraProvider = DependencyService.Get<ICameraProvider>();
            TakePicture = new Command(async () => await TakePictureAsync());
            this.cameraProvider = cameraProvider;
        }

        private async Task TakePictureAsync()
        {
            var photoResult = await cameraProvider.TakePictureAsync();
            if (photoResult != null)
            {
                Picture = photoResult.Picture;
            }
        }

        void ShowHidePassword()
        {
            if (PasswordImage == "view.png")
            {
                PasswordImage = "hide.png";
                IsPassword = false;
            }
            else
            {
                PasswordImage = "view.png";
                IsPassword = true;
            }
        }

        void RegisterUser()
        {
            IsBusy = true;
            App.Database.SaveItemAsync<User>(User).ContinueWith((t) => { IsBusy = false;
                this.Navigation.PushAsync(new MainPage());
            });
        }
    }
}
