namespace projetoHope.Views;

public partial class PgPrincipalView : ContentPage
{
	public PgPrincipalView()
	{
		InitializeComponent();
        AnimateImage();
    }

    async Task AnimateImage()
    {

        await Task.Delay(2000);


        imgSplash.Rotation = 0;
        await imgSplash.RotateTo(360, 2000);
        imgSplash.Rotation = 0;

        await Task.Delay(1000);

        await imgSplash.ScaleTo(1.7, 2000, Easing.Linear);
        await imgSplash.ScaleTo(1.3, 1000, Easing.Linear);
        await imgSplash.ScaleTo(0.7, 1000, Easing.Linear);
        imgFlecha.TranslationY = 0;


        double alturaPagina = this.Height;
        double alturaFlecha = imgFlecha.Height > 0 ? imgFlecha.Height : imgFlecha.HeightRequest;
        double margemRodape = 16;


        double yFinal = (alturaPagina / 2) - (alturaFlecha / 2) - margemRodape;

        await imgFlecha.TranslateTo(0, 30, 200, Easing.CubicOut);
        await imgFlecha.TranslateTo(0, yFinal, 1200, Easing.CubicIn);


        Application.Current.MainPage = new NavigationPage(new PgLoginView());
    }
}