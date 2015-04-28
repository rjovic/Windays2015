using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windays.Web.Api.Data
{
    /// <summary>
    /// Our class representation of PERSON object
    /// </summary>       
    public class Person
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Range(18, 118)]
        public int Age { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public string Company { get; set; }

        public DateTime CreatedOn { get; set; }


        public Person(Guid id, string name, string location, string company, int age, Gender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Company = company;
            this.Age = age;
            this.Gender = gender;
            this.CreatedOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Male or female?
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }
}
