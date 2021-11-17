using GestContactDependencyInjection.DAL.Entities;
using GestContactDependencyInjection.DAL.Reposiotries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContactDependencyInjection.DAL.Services
{
    public class ContactService : IContactRepository
    {
        public IEnumerable<Contact> Get()
        {
            yield return new Contact() { Id = 1, LastName = "Doe", FirstName = "John", Email = "doe.john@unknow.com" };
            yield return new Contact() { Id = 2, LastName = "Doe", FirstName = "Jane", Email = "doe.jane@unknow.com" };
            yield return new Contact() { Id = 3, LastName = "Norris", FirstName = "Chuck", Email = "chuck.norris@texas.usa" };
        }
    }
}
