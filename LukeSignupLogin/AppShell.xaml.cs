using LukeSignupLogin.MVVM.Views;

namespace LukeSignupLogin
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Signinpage), typeof(Signinpage));
            Routing.RegisterRoute(nameof(Loginpage), typeof(Loginpage));
        }
    }
}
