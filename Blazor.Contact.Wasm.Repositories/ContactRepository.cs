using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Practic.Repositories {
	public class ContactRepository : IContactRepository {

		private readonly IDbConnection _dbConnection;

		public ContactRepository(IDbConnection dbConnection) {
			_dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
		}

		public async Task<IEnumerable<Shared.Contact.Contacts>> GetAll() {

			var sql = @"Select Id
                               ,FirstName
                               ,LastName
                               ,Phone
                               ,Address From Contact";
			return await _dbConnection.QueryAsync<Shared.Contact.Contacts>(sql, new { });
		}

		public async Task<Shared.Contact.Contacts> GetDetails(int id) {
			var sql = @"Select Id
                               ,FirstName
                               ,LastName
                               ,Phone
                               ,Address From Contact";
			return await _dbConnection.QueryFirstAsync<Shared.Contact.Contacts>(sql, new { Id = id});
		}

		public Task<bool> InsertContact(Shared.Contact.Contacts contacts) {
			throw new NotImplementedException();
		}
	}
}
