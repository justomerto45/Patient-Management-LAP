using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Model
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // navigation property
        public ICollection<Person> Persons { get; set; }
    }
}
