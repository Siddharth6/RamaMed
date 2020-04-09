using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models.ViewModels
{
    public class UserViewModel
    {
        public RegistrationViewModel RegistrationViewModel { get; set; }

        public LoginViewModel LoginViewModel { get; set; }
    }
}
