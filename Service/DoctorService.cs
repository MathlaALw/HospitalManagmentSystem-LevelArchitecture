using HospitalManagmentSystem_LevelArchitecture.Models;
using HospitalManagmentSystem_LevelArchitecture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Service
{
    public class DoctorService : IDoctorService
    {

        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void addDoctor(Doctor doctor)
        {
            var Doc = new Doctor
            {
                Name = doctor.Name,
                Specialization = doctor.Specialization,
                ContactNumber = doctor.ContactNumber,
                Email = doctor.Email
            };

            _doctorRepository.AddDoctor(Doc);



        }

        public IEnumerable<Doctor> GetAllDoctors() {
            return _doctorRepository.GetAllDoctors();
        }



    }
}
