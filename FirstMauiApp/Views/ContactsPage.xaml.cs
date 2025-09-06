using FirstMauiApp.Models;
using Contact = FirstMauiApp.Models.Contact;

namespace FirstMauiApp.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		//List<string> contacts = new List<string>() { "John Doe", "Jason Momohe", "Johny Deapth", "Jerry Jopa" };

		List<Contact> contacts = ContactRepository.GetContacts();

		listContacts.ItemsSource = contacts;
	}
	

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (listContacts.SelectedItem != null) 
		{
			await Shell.Current.GoToAsync($"{nameof(EditContactsPage)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
		}
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		listContacts.SelectedItem = null;
    }
}