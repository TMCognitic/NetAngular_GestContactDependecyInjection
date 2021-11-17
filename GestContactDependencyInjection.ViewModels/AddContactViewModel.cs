using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Patterns.Mvvm.ViewModels;

namespace GestContactDependencyInjection.ViewModels
{
    public class AddContactViewModel : ViewModelBase
    {
        private string? _lastName;
        private string? _firstName;
        private string? _email;

        public string? LastName 
        { 
            get => _lastName; 
            set => Set(ref _lastName, value); 
        }

        public string? FirstName 
        { 
            get => _firstName; 
            set => Set(ref _firstName, value); 
        }

        public string? Email 
        { 
            get => _email; 
            set => Set(ref _email, value); 
        }
    }
}
