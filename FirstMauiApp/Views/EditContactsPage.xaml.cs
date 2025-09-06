using System.Runtime.CompilerServices;
using FirstMauiApp.Models;
using Contact = FirstMauiApp.Models.Contact;

namespace FirstMauiApp.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactsPage : ContentPage
{
	private Contact contact;
	public EditContactsPage()
	{
		
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));	
			lblName.Text = contact.Name;
		}
	}
}