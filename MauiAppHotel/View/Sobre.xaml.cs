namespace MauiAppHotel.View;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

	private async void OnVoltarButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PopToRootAsync();
    }
}