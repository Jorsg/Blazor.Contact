using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Contacts.Practic.Client.Services {
	public class ContactService : IContactService {

		private readonly HttpClient _httpClient;

		public ContactService(HttpClient httpClient) {
			
			_httpClient = httpClient ?? throw new ArgumentNullException( nameof(httpClient));
		}

		public async Task<IEnumerable<Practic.Shared.Contact.Contacts>> GetAll() {
			return await _httpClient.GetFromJsonAsync<IEnumerable<Practic.Shared.Contact.Contacts>>($"api/Contacts");
		}

		public async Task<Practic.Shared.Contact.Contacts> GetDetails(int Id) {
			return await _httpClient.GetFromJsonAsync<Practic.Shared.Contact.Contacts>($"api/Contacts/{Id}");
		}
	}
}
