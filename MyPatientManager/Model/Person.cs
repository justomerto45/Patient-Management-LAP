using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string SVN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsUser { get; set; }
        
        public int AddressId { get; set; }
        public int TreatmentId { get; set; }

        // Navigation properties
        public Adress Adress { get; set; }
        public ICollection<Treatment> Treatments { get; set; }
    }
}
