using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp.Domains
{
    public class PhoneContact
    {
        public Guid PhoneContactId { get; set; }

        [Display(Name = "شماره موبایل")]
        [StringLength(11, ErrorMessage = "{0} شماره موبایل راصحیح وارد کنید", MinimumLength = 11)]
        [Required(ErrorMessage = "{0} مقدار اجباری می باشد")]

        public string PhoneNumber { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
