namespace FirstMauiApp.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<string> onError;
    public event EventHandler<EventArgs> onSave;
    public event EventHandler<EventArgs> onCancel;
    public ContactControl()
    {
        InitializeComponent();
    }

    public string Name
    {
        get
        {
            return entryName.Text;
        }
        set
        {
            entryName.Text = value;
        }
    }

    public string Email
    {
        get
        {
            return entryEmail.Text;
        }
        set
        {
            entryEmail.Text = value;
        }
    }
    public string Phone
    {
        get
        {
            return entryPhone.Text;
        }
        set
        {
            entryPhone.Text = value;
        }
    }

    public string Address
    {
        get
        {
            return entryAddress.Text;
        }
        set
        {
            entryAddress.Text = value;
        }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            onError?.Invoke(sender, "Name is required");
            //DisplayAlert("Error", "Name is required", "OK");
            return;
        }
        if (emailValidator.IsNotValid)
        {
            foreach (var error in emailValidator.Errors)
            {
                if (error.ToString() != "Email is required.")
                {
                    onError?.Invoke(sender, error.ToString());
                    return;
                }
                else onError?.Invoke(sender, "Email is required.");
                return;
            }
            return;
        }

        onSave?.Invoke(sender, e);     }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        onCancel?.Invoke(sender, e);
    }
}