using System.Runtime.InteropServices;

namespace LukeSignupLogin.MVVM.Views;
public partial class Signinpage : ContentPage
{
    public Signinpage()
	{
		InitializeComponent();
    }

    private async void Return_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public void Sign_in_Clicked(object sender, EventArgs e)
    {
        
    }
}
