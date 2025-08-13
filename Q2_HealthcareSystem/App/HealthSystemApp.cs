using System;
using System.Collections.Generic;
using Q2_HealthcareSystem.Models;
using Q2_HealthcareSystem.Repositories;

namespace Q2_HealthcareSystem.App
{
    public class HealthSystemApp
    {
        private readonly Repository<Patient> _patientRepo = new Repository<Patient>();
        private readonly Repository<Prescription> _prescriptionRepo = new Repository<Prescription>();
        private Dictionary<int, List<Prescription>> _prescriptionMap = new Dictionary<int, List<Prescription>>();

        public void SeedData()
        {
            // Patients
            _patientRepo.Add(new Patient(1, "Alice Smith", 30, "Female"));
            _patientRepo.Add(new Patient(2, "John Doe", 45, "Male"));
            _patientRepo.Add(new Patient(3, "Mary Johnson", 60, "Female"));

            // Prescriptions
            _prescriptionRepo.Add(new Prescription(1, 1, "Amoxicillin", DateTime.Now.AddDays(-10)));
            _prescriptionRepo.Add(new Prescription(2, 1, "Ibuprofen", DateTime.Now.AddDays(-5)));
            _prescriptionRepo.Add(new Prescription(3, 2, "Paracetamol", DateTime.Now.AddDays(-2)));
            _prescriptionRepo.Add(new Prescription(4, 3, "Vitamin D", DateTime.Now.AddDays(-1)));
        }

        public void BuildPrescriptionMap()
        {
            _prescriptionMap = new Dictionary<int, List<Prescription>>();
            List<Prescription> all = _prescriptionRepo.GetAll();

            for (int i = 0; i < all.Count; i++)
            {
                Prescription p = all[i];
                if (!_prescriptionMap.ContainsKey(p.PatientId))
                {
                    _prescriptionMap[p.PatientId] = new List<Prescription>();
                }
                _prescriptionMap[p.PatientId].Add(p);
            }
        }

        public void PrintAllPatients()
        {
            Console.WriteLine();
            Console.WriteLine("All Patients:");
            List<Patient> all = _patientRepo.GetAll();
            for (int i = 0; i < all.Count; i++)
            {
                Console.WriteLine(all[i].ToString());
            }
        }

        public void PrintPrescriptionsForPatient(int id)
        {
            Console.WriteLine();
            if (_prescriptionMap.ContainsKey(id))
            {
                Console.WriteLine("Prescriptions for Patient ID " + id + ":");
                List<Prescription> list = _prescriptionMap[id];
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("No prescriptions found for patient ID " + id);
            }
        }
    }
}
