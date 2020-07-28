using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Name required.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Locaion required")]
        public string Location { get; set; }


    }
}
