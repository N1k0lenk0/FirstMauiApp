using FirstMauiApp.Views;

namespace FirstMauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
            Routing.RegisterRoute(nameof(EditContactsPage), typeof(EditContactsPage));
            Routing.RegisterRoute(nameof(AddContactsPage), typeof(AddContactsPage));
        }
    }
}
