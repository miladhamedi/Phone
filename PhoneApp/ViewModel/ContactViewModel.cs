using PhoneApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp.ViewModel
{
    public class ContactViewModel
    {
        public Guid ContactId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public List<PhoneContact> PhoneContacts { get; set; }
    }
}
