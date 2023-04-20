using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Practic.Repositories {
	public interface IContactRepository {

		Task<bool> InsertContact(Shared.Contact.Contacts contacts);
		Task<IEnumerable<Shared.Contact.Contacts>> GetAll();
		Task<Shared.Contact.Contacts> GetDetails(int id);
	}
}
