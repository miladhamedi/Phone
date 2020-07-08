using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneApp.Data;
using PhoneApp.Domains;

namespace PhoneApp.Contacts
{
    public class PhoneContactRepository : IPhoneContactRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PhoneContactRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void AddPhoneContact(PhoneContact phoneContactRepository)
        {
            PhoneContact phoneContact = new PhoneContact();
            phoneContact.PhoneNumber = phoneContactRepository.PhoneNumber;
            phoneContact.ContactId = phoneContactRepository.ContactId;
            applicationDbContext.PhoneContacts.Add(phoneContact);
            applicationDbContext.SaveChanges();
        }
        public void Delete(PhoneContact contact)
        {
            applicationDbContext.PhoneContacts.Remove(contact);
            applicationDbContext.SaveChanges();
        }

        public List<PhoneContact> GetAll()
        {
            return applicationDbContext.PhoneContacts.ToList();
        }

        public PhoneContact GetById(Guid PhoneContactId)
        {
            var phoneContact = applicationDbContext.PhoneContacts.Find(PhoneContactId);
            return phoneContact;
        }
    }
}
