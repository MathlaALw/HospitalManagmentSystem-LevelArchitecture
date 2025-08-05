using HospitalManagmentSystem_LevelArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        // get the database context
        private readonly DoctorDbContext _context;

        // Constructor to initialize the context
        public DoctorRepository(DoctorDbContext context)
        {
            _context = context;
        }

        // CRUD operations for Doctor entity
        public void AddDoctor(Doctor doctor)
        {

            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }


        public Doctor GetDoctorById(int id)
        {
            return _context.Doctors.Find(id);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.Find(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }
        }
    }
}
