namespace MauiAppHotel.View;

public partial class InformacaoQuarto : ContentPage
{
	public InformacaoQuarto()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}