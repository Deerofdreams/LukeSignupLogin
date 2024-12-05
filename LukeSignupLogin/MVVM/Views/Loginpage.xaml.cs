namespace LukeSignupLogin;

public partial class Loginpage : ContentPage
{
	public Loginpage()
	{
		InitializeComponent();
	}
    private async void Return_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void Log_In_Clicked(object sender, EventArgs e)
    {

    }

}