using GestContactDependencyInjection.DAL.Reposiotries;
using GestContactDependencyInjection.ViewModels.Messages;
using System.Collections.ObjectModel;
using Tools.Patterns.Mediator;
using Tools.Patterns.Mvvm.Commands;
using Tools.Patterns.Mvvm.ViewModels;

namespace GestContactDependencyInjection.ViewModels
{
    public class MainViewModel : ViewModelCollectionBase<ContactViewModel>
    {
        private readonly IContactRepository _repository;
        private ICommand? _addCommand;

        public ICommand AddCommand { get => _addCommand ??= new DelegateCommand(OpenAddWindow); }

        public MainViewModel(IContactRepository repository)
        {
            _repository = repository;
        }

        private void OpenAddWindow()
        {
            Messenger<WindowTypes>.Default.Send(WindowTypes.AddContact);
        }

        protected override ObservableCollection<ContactViewModel> LoadItems()
        {
            return new ObservableCollection<ContactViewModel>(_repository.Get().Select(c => new ContactViewModel(c)));
        }
    }
}