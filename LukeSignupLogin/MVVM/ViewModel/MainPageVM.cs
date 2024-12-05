using LukeSignupLogin.MVVM.Views;
using System.Windows.Input; 
namespace LukeSignupLogin.MVVM.ViewModel
{
    internal class MainPageVM
    {
        public ICommand NavigateCommand { get; }

        public MainPageVM()
        {
            NavigateCommand = new Command(OnNavigate);
        }

        private async void OnNavigate()
        {
            await Shell.Current.GoToAsync(nameof(Signinpage));
        }
    }
}
