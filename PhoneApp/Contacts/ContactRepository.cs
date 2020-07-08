using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneApp.Data;
using PhoneApp.Domains;
using PhoneApp.ViewModel;

namespace PhoneApp.Contacts
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ContactRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Guid AddContct(Contact contact)
        {
            var contactVM = new Contact();

            contactVM.Firstname = contact.Firstname;
            contactVM.LastName = contact.LastName;
            contactVM.NationalCode = contact.NationalCode;
           
            applicationDbContext.Add(contactVM);
            applicationDbContext.SaveChanges();
            return contactVM.ContactId;
        }

        public void Delete(Contact contact)
        {
            applicationDbContext.Contacts.Remove(contact);
            applicationDbContext.SaveChanges();
        }

        public List<Contact> GetAll()
        {
            var Contactlist = applicationDbContext.Contacts.Include(c => c.PhoneContacts).ToList();
            return Contactlist;
        }

        public Contact GetById(Guid ContactId)
        {
            var Contact = applicationDbContext.Contacts.Find(ContactId);
            return Contact;
        }

        public void UpdateContact(Contact contact)
        {
            var contacE = new Contact();

            contacE.Firstname = contact.Firstname;
            contacE.LastName = contact.LastName;
            contacE.NationalCode = contact.NationalCode;

            applicationDbContext.Attach(contacE);
            applicationDbContext.Entry(contacE).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
        }
    }
}
