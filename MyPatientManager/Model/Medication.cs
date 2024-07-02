using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Model
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }

        // Navigation property
        public ICollection<Prescription> Recipes { get; set; }
    }
}
