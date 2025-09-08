using System.Runtime.CompilerServices;
using FirstMauiApp.Models;
using Contact = FirstMauiApp.Models.Contact;

namespace FirstMauiApp.Views;

[QueryProperty(nameof(ContactId), "Id")]
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
            if (contact != null)
            {
                contactCtrl.Name = contact.Name;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
                contactCtrl.Address = contact.Address;

            }
        }
    }

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
        contact.Name = contactCtrl.Name;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;
        contact.Address = contactCtrl.Address;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");

    }

    private void contactCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}