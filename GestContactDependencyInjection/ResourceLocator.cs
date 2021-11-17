using GestContactDependencyInjection.DAL.Reposiotries;
using GestContactDependencyInjection.DAL.Services;
using GestContactDependencyInjection.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Patterns.Locator;

namespace GestContactDependencyInjection
{
    public class ResourceLocator : LocatorBase
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IContactRepository, ContactService>();
            services.AddSingleton<MainViewModel>();
            services.AddTransient<AddContactViewModel>();
        }

        public MainViewModel? Main 
        { 
            get { return GetResource<MainViewModel>(); } 
        }

        public AddContactViewModel? AddContact
        {
            get { return GetResource<AddContactViewModel>(); }
        }
    }
}
