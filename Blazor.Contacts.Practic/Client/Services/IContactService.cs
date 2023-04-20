using Blazor.Contacts.Practic.Shared.Contact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Practic.Client.Services {
	public interface IContactService {
		Task<IEnumerable<Practic.Shared.Contact.Contacts>> GetAll();
		Task<Practic.Shared.Contact.Contacts> GetDetails(int Id);
	}
}
