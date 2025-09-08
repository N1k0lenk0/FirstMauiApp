using System.Collections.ObjectModel;
using FirstMauiApp.Models;
using Contact = FirstMauiApp.Models.Contact;

namespace FirstMauiApp.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());

		listContacts.ItemsSource = contacts;    }
	

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

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactsPage));
    }
}