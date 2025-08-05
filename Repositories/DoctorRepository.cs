using HospitalManagmentSystem_LevelArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Repositories
{
    public class DoctorRepository
    {
        // get the database context
        private readonly DoctorDbContext _context;

        // Constructor to initialize the context
        public DoctorRepository(DoctorDbContext context)
        {
            _context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor), "Doctor cannot be null");
            }
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }


        public Doctor GetDoctorById(int id)
        {
            return _context.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor), "Doctor cannot be null");
            }
            var existingDoctor = _context.Doctors.FirstOrDefault(d => d.Id == doctor.Id);
            if (existingDoctor == null)
            {
                throw new KeyNotFoundException($"Doctor with ID {doctor.Id} not found");
            }
            existingDoctor.Name = doctor.Name;
            existingDoctor.Specialization = doctor.Specialization;
            existingDoctor.ContactNumber = doctor.ContactNumber;
            _context.SaveChanges();
        }

    }
}
