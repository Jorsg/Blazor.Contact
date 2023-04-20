using Blazor.Contacts.Practic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Contacts.Practic.Server.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase {

		private readonly IContactRepository _contactRepository;

		public ContactsController(IContactRepository contactRepository) {
			_contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
		}

		[HttpGet]
		public async Task<IEnumerable<Shared.Contact.Contacts>> GetAll() 
	    {			
			return await _contactRepository.GetAll();
		}

		[HttpGet("{Id}")]
		public async Task<Shared.Contact.Contacts> GetById(int Id) {
			return await _contactRepository.GetDetails(Id);
		}
	}
}
