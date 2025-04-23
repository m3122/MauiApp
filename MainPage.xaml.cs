namespace MiAppMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

	private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
	{
		int r = (int)SliderR.Value;
		int g = (int)SliderG.Value;
		int b = (int)SliderB.Value;

		LabelRGB.Text = $"({r}, {g}, {b})";
		this.BackgroundColor = Color.FromRgb(r, g, b);

		string hex = $"#{r:X2}{g:X2}{b:X2}";
		LabelHex.Text = hex;
	}

	private async void OnHexLabelTapped(object sender, EventArgs e)
	{
		await Clipboard.SetTextAsync(LabelHex.Text);
		await DisplayAlert("Copiado", $"Color {LabelHex.Text} copiado al portapapeles.", "OK");
	}

	private void OnRandomColorClicked(object sender, EventArgs e)
	{
		Random rand = new Random();
		SliderR.Value = rand.Next(256);
		SliderG.Value = rand.Next(256);
		SliderB.Value = rand.Next(256);
	}



}
