using System;
using Q2_HealthcareSystem.App;

namespace Q2_HealthcareSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthSystemApp app = new HealthSystemApp();

            app.SeedData();
            app.BuildPrescriptionMap();
            app.PrintAllPatients();

            Console.Write("\nEnter Patient ID to view prescriptions: ");
            int patientId;
            if (int.TryParse(Console.ReadLine(), out patientId))
            {
                app.PrintPrescriptionsForPatient(patientId);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}