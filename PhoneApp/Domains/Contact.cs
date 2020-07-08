using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp.Domains
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        [Display(Name = "نام")]
        [StringLength(35, ErrorMessage = "{0} نام خانوادگی را صحیح وارد کنید", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} مقدار اجباری می باشد")]

        public string Firstname { get; set; }
        [Display(Name = "نام خانوادگی")]
        [StringLength(35, ErrorMessage = "{0} نام خانوادگی را صحیح وارد کنید", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} مقدار اجباری می باشد")]

        public string LastName { get; set; }

        [Display(Name = "کدملی")]
        [StringLength(10, ErrorMessage = "{0} کدملی را صحیح وارد کنید", MinimumLength = 10)]
        [Required(ErrorMessage = "{0} مقدار اجباری می باشد")]

        public string NationalCode { get; set; }

        public List<PhoneContact> PhoneContacts { get; set; }

    }
}
