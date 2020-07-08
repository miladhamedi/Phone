using PhoneApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp.Contacts
{
    public interface IPhoneContactRepository
    {
        void Delete(PhoneContact contact);
        void AddPhoneContact(PhoneContact contact);
        PhoneContact GetById(Guid PhoneContactId);
        List<PhoneContact> GetAll();
    }
}
