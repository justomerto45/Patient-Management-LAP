using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Model
{
    public class Treatment
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public ICollection<Prescription> Prescriptions { get; set; }
        public Person Person { get; set; }
    }
}
