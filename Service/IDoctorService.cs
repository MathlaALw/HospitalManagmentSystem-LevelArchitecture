using HospitalManagmentSystem_LevelArchitecture.Models;

namespace HospitalManagmentSystem_LevelArchitecture.Service
{
    public interface IDoctorService
    {
        void addDoctor(Doctor doctor);
        IEnumerable<Doctor> GetAllDoctors();
    }
}