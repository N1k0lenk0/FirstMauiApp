using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstMauiApp.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
		{
		new Contact { Name="John Doe", Email="ababahalamaha@gmail.com"},
		new Contact { Name="Jason Momohe", Email="fuckthepolice@gmail.com"},
		new Contact { Name = "Johny Depth", Email = "fuckamberheart@gmail.com" },
		new Contact { Name = "Jerry Jopa", Email = "justjopa@gmail.com" },
		};

		public static List <Contact> GetContacts() => _contacts;

		public static Contact GetContactById (int contactId)
		{
			return _contacts.FirstOrDefault(x => x.ContactId == contactId);
		}
    }
}
