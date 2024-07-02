using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Model
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public int MedicationId { get; set; }
        public int TreatmentId { get; set; }

        public Treatment Treatment { get; set; }
        public Medication Medication { get; set; }
    }
}
