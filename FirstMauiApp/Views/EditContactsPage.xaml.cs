namespace FirstMauiApp.Views;

public partial class EditContactsPage : ContentPage
{
	public EditContactsPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
}