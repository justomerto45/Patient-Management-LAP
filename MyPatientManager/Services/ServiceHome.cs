using Microsoft.EntityFrameworkCore;
using MyPatientManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Services
{
    public class ServiceHome
    {
        private MyPatientManagerDbContext _dbContext;

        public ServiceHome(MyPatientManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Treatment> GetAllTreatments()
        {
            try
            {
                // Verwendet Include und ThenInclude, um zugehörige Daten zu laden
                return _dbContext.Treatments
                                 .Include(treatment => treatment.Person) // Lädt die zugehörige Person
                                 .Include(treatment => treatment.Prescriptions) // Lädt die zugehörigen Prescriptions
                                     .ThenInclude(prescription => prescription.Medication) 
                                 .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Treatment>();
            }
        }
    }
}
