using HospitalManagmentSystem_LevelArchitecture.Models;
using HospitalManagmentSystem_LevelArchitecture.Repositories;
using HospitalManagmentSystem_LevelArchitecture.Service;

namespace HospitalManagmentSystem_LevelArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the database context
            using DoctorDbContext context = new DoctorDbContext();
            // Ensure the database is created
            context.Database.EnsureCreated();

            
            IDoctorRepository doctorRepository = new DoctorRepository(context);
            IDoctorService doctorService = new DoctorService(doctorRepository);


            
            while (true)
            {
                Console.WriteLine("1. Add doctor");
                Console.WriteLine("2. View All Doctor");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Adding Doctors...");
                        Console.WriteLine("Enter doctor name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter doctor specialization");
                        string specialization = Console.ReadLine();
                        Console.WriteLine("Enter doctor contact number");
                        string contactNumber = Console.ReadLine();
                        Console.WriteLine("Enter doctor email");
                        string email = Console.ReadLine();


                        Doctor newDoctor = new Doctor
                        {
                            Name = name,
                            Specialization = specialization,
                            ContactNumber = contactNumber,
                            Email = email
                        };

                        doctorService.addDoctor(newDoctor);
                        break;

                    
                      

                    case "2":
                        Console.WriteLine("Viewing All Doctors...");
                        var doctors = doctorService.GetAllDoctors();

                        foreach (var doctor in doctors)
                        {
                            Console.WriteLine($"Doctor ID: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}, Contact: {doctor.ContactNumber}, Email: {doctor.Email}");
                        }
                        break;

                   

                    case "0":
                        Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }












        }
    }
}
