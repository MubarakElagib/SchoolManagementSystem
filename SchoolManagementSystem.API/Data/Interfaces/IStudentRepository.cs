using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolManagementSystem.API.Data.Models.Entities;

namespace SchoolManagementSystem.API.Data.Interfaces
{
    public interface IStudentRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(int id);
        Task<bool> SaveAll();
    }
}