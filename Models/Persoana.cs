using Blazor_Components_VM_Ex.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Components_VM_Ex.Models
{
    public class Persoana
    {
        public Guid Id { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Is required")]
        [StringLength(16, ErrorMessage = "Name too long (16 character limit).")]
        public string LastName { get; set; }

        [StringLength(16, ErrorMessage = "Name too long (16 character limit).")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Date of birth is mandatory.")]
        [Display(Name = "Birth Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Genre is Mandatory")]
        public Genre Genre { get; set; }

        [Display(Name = "Is 18 years old")]
        [Required(ErrorMessage = "This field is mandatory.")]
        public bool IsMajor { get; set; }

        [Required(ErrorMessage = "Phone is mandatory.")]
        [StringLength(10, ErrorMessage = "Phone too long (10 character limit).")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Email is mandatory!")]
        [EmailAddress(ErrorMessage = "Email Adress is Invalid!")]
        public string Email { get; set; }
    }
}
