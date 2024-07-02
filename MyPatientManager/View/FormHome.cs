using MyPatientManager.Model;
using MyPatientManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPatientManager.View
{
    public partial class FormHome : Form
    {
        private MyPatientManagerDbContext _dbContext;
        private ServiceLogin _serviceLogin;
        private ServiceHome _serviceHome;
        private string _username;
        public FormHome(string username)
        {
            InitializeComponent();
            _username = username;
            UpdateWelcomeLabel();
            _dbContext = new MyPatientManagerDbContext();

            _serviceHome = new ServiceHome(_dbContext);
            LoadAndDisplayTreatments();
        }

        //TODO: datagridview header text in german
        //TODO: add CRUD operation logic to the buttons given
        //TODO: add validation to the textboxes
        //TODO: add error handling
        //TODO: add logic to menustrips (data -> import , export pdf? json? csv? / patient -> add, edit, delete / account -> overview, edit info
        //                               "?"-Button -> logout, info, version)
        //TODO: add logout functionality

        private void LoadAndDisplayTreatments()
        {
            var treatments = _serviceHome.GetAllTreatments();

            var displayData = treatments.Select(treatment => new
            {
                treatment.Id,
                PatientName = $"{treatment.Person.FName} {treatment.Person.LName}",
                treatment.Notes,
                treatment.CreatedAt,
                Prescriptions = string.Join(", ", treatment.Prescriptions.Select(p => $"{p.Medication.Name} x{p.Amount}"))
            }).ToList();

            dataGridViewPatients.DataSource = displayData;
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            var searchQuery = textBoxSearch.Text.ToLower();
            var treatments = _serviceHome.GetAllTreatments();

            var displayData = treatments.Select(treatment => new
            {
                treatment.Id,
                PatientName = $"{treatment.Person.FName} {treatment.Person.LName}",
                treatment.Notes,
                treatment.CreatedAt,
                Prescriptions = string.Join(", ", treatment.Prescriptions.Select(p => $"{p.Medication.Name} x{p.Amount}"))
            });

            if (!string.IsNullOrEmpty(searchQuery))
            {
                displayData = displayData.Where(treatment => treatment.PatientName.ToLower().Contains(searchQuery));
            }

            dataGridViewPatients.DataSource = displayData.ToList();
        }
        private void UpdateWelcomeLabel()
        {
            labelWelcome.Text = $"Willkommen {_username}";
        }
    }
}
