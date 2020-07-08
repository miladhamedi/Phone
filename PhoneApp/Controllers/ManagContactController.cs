using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoneApp.Contacts;
using PhoneApp.Data;
using PhoneApp.Domains;
using PhoneApp.ViewModel;

namespace PhoneApp.Controllers
{
    [Authorize]
    public class ManagContactController : Controller
    {
        private readonly IContactRepository contactRepository;
        private readonly IPhoneContactRepository phoneContactRepository;
        private readonly ApplicationDbContext applicationDbContext;

        public ManagContactController(IContactRepository contactRepository, IPhoneContactRepository phoneContactRepository, ApplicationDbContext applicationDbContext)
        {
            this.contactRepository = contactRepository;
            this.phoneContactRepository = phoneContactRepository;
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult List()
        {
            var ContactList = contactRepository.GetAll();
            return View(ContactList);
        }

        public IActionResult ListPhoneNumber()
        {
            var ContactList = phoneContactRepository.GetAll();
            return View(ContactList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            var id = contactRepository.AddContct(contact);


            return RedirectToAction("CreatePhoneNumber", new { contactid = id });
        }

        public IActionResult CreatePhoneNumber(Guid contactid)
        {
            ViewBag.ContactId = contactid;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePhoneNumber(PhoneContact contactph, int contactid)
        {
            if (!ModelState.IsValid)
            {
                return View(contactph);
            }
            contactph.ContactId = contactid;

            phoneContactRepository.AddPhoneContact(contactph);


            return RedirectToAction("List");
        }


        //DeletdContct
        public IActionResult Delete(Guid ContactId)
        {
            var item = contactRepository.GetById(ContactId);
            contactRepository.Delete(item);
            return RedirectToAction("List");
        }


        //DeletePhoneNumber
        public IActionResult DeletePhone(Guid PhoneContactId)
        {
            var item = phoneContactRepository.GetById(PhoneContactId);
            phoneContactRepository.Delete(item);
            return RedirectToAction("ListPhoneNumber");
        }


        public IActionResult Update(Guid ContactID)
        {
            var item = contactRepository.GetById(ContactID);

            var ContactVM = new ContactViewModel ();

            ContactVM.Firstname = item.Firstname;
            ContactVM.LastName = item.LastName;
            ContactVM.NationalCode = item.NationalCode;

            return View(ContactVM);
        }


        [HttpPost]
        public IActionResult Update(ContactViewModel contact)
        {
            var item = contactRepository.GetById(contact.ContactId);

            item.Firstname = contact.Firstname;
            item.LastName = contact.LastName;
            item.NationalCode = contact.NationalCode;

            applicationDbContext.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult UpdatePhone(Guid PhoneContactId)
        {
            var item = phoneContactRepository.GetById(PhoneContactId);

            var ContactPhoneVM = new ContactPhoneViewModel();

            ContactPhoneVM.PhoneNumber = item.PhoneNumber;

            return View(ContactPhoneVM);
        }


        [HttpPost]
        public IActionResult UpdatePhone(ContactPhoneViewModel contact)
        {
            var item = phoneContactRepository.GetById(contact.PhoneContactId);

            item.PhoneNumber = contact.PhoneNumber;

            applicationDbContext.SaveChanges();

            return RedirectToAction("ListPhoneNumber");
        }


    }
}