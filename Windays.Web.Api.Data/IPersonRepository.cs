using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windays.Web.Api.Data
{
    /// <summary>
    /// Our person repository interface
    /// </summary>
    public interface IPersonRepository
    {
        Person GetPerson(Guid id);
        List<Person> GetPeople(int? skip, int? take);
        void CreatePerson(Person person);
        void UpdatePerson(Guid id, Person person);
        void DeletePerson(Guid id);
    }
}
