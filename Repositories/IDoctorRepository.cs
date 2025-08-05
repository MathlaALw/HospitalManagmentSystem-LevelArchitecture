using HospitalManagmentSystem_LevelArchitecture.Models;

namespace HospitalManagmentSystem_LevelArchitecture.Repositories
{
    public interface IDoctorRepository
    {
        void AddDoctor(Doctor doctor);
        void DeleteDoctor(int id);
        List<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int id);
        void UpdateDoctor(Doctor doctor);
    }
}