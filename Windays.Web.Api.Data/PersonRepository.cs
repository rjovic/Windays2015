using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windays.Web.Api.Data
{
    /// <summary>
    /// Our dummy persons repository
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _data;

        public PersonRepository()
        {
            _data = PersonInMemoryStorage.Instance.People;
        }

        /// <summary>
        /// Get person by ID
        /// </summary>
        /// <param name="id">Person ID</param>
        /// <returns></returns>
        public Person GetPerson(Guid id)
        {
            var actualPerson = _data.FirstOrDefault(p => p.Id.Equals(id));
            if (actualPerson == null)
            {
                throw new PersonNotFoundException("Person doesn't exists!");
            }

            return actualPerson;
        }

        /// <summary>
        /// Get list of people
        /// </summary>
        /// <param name="skip">Skip parametar for pagination</param>
        /// <param name="take">Take parametar for pagination</param>
        /// <returns></returns>
        public List<Person> GetPeople(int? skip, int? take)
        {
            return _data;
        }

        /// <summary>
        /// Creates new person record
        /// </summary>
        /// <param name="person">Person object</param>
        public void CreatePerson(Person person)
        {
            person.Id = Guid.NewGuid();
            person.CreatedOn = DateTime.UtcNow;

            _data.Add(person);
        }

        /// <summary>
        /// Modify current person object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="person"></param>
        public void UpdatePerson(Guid id, Person person)
        {
            var actualPerson = GetPerson(id);

            actualPerson.Name = person.Name;
            actualPerson.Location = person.Location;
            actualPerson.Age = person.Age;
            actualPerson.Gender = person.Gender;
            actualPerson.Company = person.Company;
        }

        public void DeletePerson(Guid id)
        {
            var actualPerson = GetPerson(id);
            _data.Remove(actualPerson);
        }
    }
}
