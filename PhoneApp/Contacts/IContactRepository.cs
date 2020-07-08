using PhoneApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp.Contacts
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        Guid AddContct(Contact contact);
        Contact GetById(Guid ContactId);
        void Delete(Contact contact);
        void UpdateContact(Contact contact);
    }
}
