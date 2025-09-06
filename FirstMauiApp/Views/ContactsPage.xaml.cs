

namespace FirstMauiApp.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		//List<string> contacts = new List<string>() { "John Doe", "Jason Momohe", "Johny Deapth", "Jerry Jopa" };
		
		List<Contact> contacts = new List<Contact>()
		{
		new Contact { Name="John Doe", Email="ababahalamaha@gmail.com"},
		new Contact { Name="Jason Momohe", Email="fuckthepolice@gmail.com"},
		new Contact { Name="Johny Depth", Email="fuckamberheart@gmail.com"},
		new Contact { Name="Jerry Jopa", Email="justjopa@gmail.com"},
		};

		listContacts.ItemsSource = contacts;
	}
	public class Contact
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (listContacts.SelectedItem != null) {
			await Shell.Current.GoToAsync(nameof(EditContactsPage));
		}
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		listContacts.SelectedItem = null;
    }
}