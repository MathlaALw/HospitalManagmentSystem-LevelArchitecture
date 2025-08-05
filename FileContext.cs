using HospitalManagmentSystem_LevelArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture
{
    public static class FileContext
    {
        // Path of the JSON file where doctors will be stored
        private static string filePath = "Doctors.json";

        // Method to load doctors from the JSON file
        public static List<Doctor> LoadDoctors()
        {
            if (!File.Exists(filePath))
            {
                return new List<Doctor>();
            }
            var json = File.ReadAllText(filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Doctor>>(json) ?? new List<Doctor>();
        }

        // Method to save doctors to the JSON file
        public static void SaveDoctors(List<Doctor> doctors)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(doctors);
            File.WriteAllText(filePath, json);
        }
    }
}
