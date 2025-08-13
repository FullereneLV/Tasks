using DoctorAppointmentDemo.Data.Interfaces;
using DoctorAppointmentDemo.Service.Services;
using MyDoctorAppointment.Data.Configuration;
using MyDoctorAppointment.Domain.Entities;
using MyDoctorAppointment.Service.Interfaces;
using MyDoctorAppointment.Service.Services;

namespace MyDoctorAppointment
{
    public class DoctorAppointment
    {
        private readonly IDoctorService _doctorService;

        public DoctorAppointment(string appSettings, ISerializationService serializationService)
        {
            _doctorService = new DoctorService(appSettings, serializationService);
        }

        public void Menu()
        {
            //while (true)
            //{
            //    // add Enum for menu items and describe menu
            //}

            Console.WriteLine("Current doctors list: ");
            var docs = _doctorService.GetAll();

            foreach (var doc in docs)
            {
                Console.WriteLine(doc.Name);
                Console.WriteLine("Salary: " + doc.Experience);
            }

            Console.WriteLine("Adding doctor: ");

            var newDoctor = new Doctor
            {
                Name = "VasyaNEW",
                Surname = "Petrov52",
                Experience = 20,
                DoctorType = Domain.Enums.DoctorTypes.Dentist
            };

            _doctorService.Create(newDoctor);

            Console.WriteLine("Current doctors list: ");
            docs = _doctorService.GetAll();

            foreach (var doc in docs)
            {
                Console.WriteLine(doc.Name);
            }
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Select data format:");
            Console.WriteLine("1. XML");
            Console.WriteLine("2. JSON");

            string? choice = Console.ReadLine();
            DoctorAppointment? doctorAppointment = null;

            while (true)
            {
                if (choice.Equals("1"))
                {
                    doctorAppointment = new DoctorAppointment(Constants.XmlAppSettingsPath, new XmlDataSerializerService());
                    break;
                }
                else if (choice.Equals("2"))
                {
                    doctorAppointment = new DoctorAppointment(Constants.JsonAppSettingsPath, new JsonDataSerializerService());
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong choice.");
                    choice = Console.ReadLine();
                }
            }
            doctorAppointment.Menu();
        }
    }
}