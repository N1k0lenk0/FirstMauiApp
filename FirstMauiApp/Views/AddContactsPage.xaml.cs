using FirstMauiApp.Models;

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

    private void contactCtrl_onSave(object sender, EventArgs e)
    {
        ContactRepository.AddContact(new Models.Contact
        {
            Name = contactCtrl.Name,
            Email = contactCtrl.Email,
            Address = contactCtrl.Address,
            Phone = contactCtrl.Phone
        });
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_onCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}