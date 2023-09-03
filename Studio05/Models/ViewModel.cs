using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Studio05.Models
{
    public class ViewModel
    {
    }

    public class FormOneViewModel {

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set;}

        public string LastName { get; set;}

    }
}