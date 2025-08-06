using HospitalManagmentSystem_LevelArchitecture.Models;
using HospitalManagmentSystem_LevelArchitecture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;

        // Constructor to initialize the repository
        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }
            


        




    }
}
