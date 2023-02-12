using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Gender { male=0,female=1}


namespace Anket
{
    internal class Person
    {
        #region Properties
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Father { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime bDate { get; set; }
        #endregion

        public Person() { }

        public Person(string? name, string? surname, string? father, string? country, string? city, string? phone, Gender gen, DateTime dbdate)
        {
            Name = name;
            Surname = surname;
            Father = father;
            Country = country;
            City = city;
            Phone = phone;
            this.Gender = gen;
            this.bDate = dbdate;
        }
    }
}
