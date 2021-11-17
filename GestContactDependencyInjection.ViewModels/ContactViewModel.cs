using GestContactDependencyInjection.DAL.Entities;
using Tools.Patterns.Mvvm.ViewModels;

namespace GestContactDependencyInjection.ViewModels
{
    public class ContactViewModel : ViewModelBase<Contact>
    {
        private string? _lastName;
        private string? _firstName;
        private string? _email;
        public ContactViewModel(Contact entity) : base(entity)
        {
            LastName = entity.LastName;
            FirstName = entity.FirstName;
            Email = entity.Email;
        }

        public int Id
        {
            get { return Entity.Id; }
        }

        public string? LastName { get => _lastName; set => Set(ref _lastName, value); }
        public string? FirstName { get => _firstName; set => Set(ref _firstName, value); }
        public string? Email { get => _email; set => Set(ref _email, value); }
    }
}