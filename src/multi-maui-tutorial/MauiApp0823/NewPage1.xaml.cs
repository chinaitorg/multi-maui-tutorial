namespace MauiApp0823;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	public bool IsConfirm { get; set; }

	/// <summary>
	/// Cancel Click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void btnCancel_Clicked(object sender, EventArgs e)
	{
        IsConfirm = false;
		await Navigation.PopAsync();
	}

	/// <summary>
	/// Confirm Click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void btnConfirm_Clicked(object sender, EventArgs e)
	{
        IsConfirm = true;
        await Navigation.PopAsync();
    }

	/// <summary>
	/// Rewrite home back func
	/// </summary>
	/// <returns></returns>
	protected override bool OnBackButtonPressed()
	{
        IsConfirm = false;
		return base.OnBackButtonPressed();
	}
}