using GestContactDependencyInjection.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContactDependencyInjection.DAL.Reposiotries
{
    public interface IContactRepository
    {
        IEnumerable<Contact> Get();
    }
}
