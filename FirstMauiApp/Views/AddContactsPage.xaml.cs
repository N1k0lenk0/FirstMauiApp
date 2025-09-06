namespace FirstMauiApp.Views;

public partial class AddContactsPage : ContentPage
{
	public AddContactsPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}