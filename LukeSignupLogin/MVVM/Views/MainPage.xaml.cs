using LukeSignupLogin.MVVM.ViewModel;
namespace LukeSignupLogin.MVVM.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }


        
        private async void Sign_up_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Signinpage));
        }

        private async void Log_in_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Loginpage));
        }
    }

}
