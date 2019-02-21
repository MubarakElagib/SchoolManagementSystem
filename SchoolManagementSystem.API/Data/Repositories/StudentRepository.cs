using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.API.Data.Interfaces;
using SchoolManagementSystem.API.Data.Models.Entities;

namespace SchoolManagementSystem.API.Data.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context) 
            => _context = context;

        public void Add<T>(T entity) where T : class 
            => _context.Add(entity);

        public void Delete<T>(T entity) where T : class
            => _context.Remove(entity);

        public async Task<Student> GetStudent(int id)
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(std => std.Id == id);

            return student;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();

            return students;
        }

        public async Task<bool> SaveAll() 
            => await _context.SaveChangesAsync() > 0;
          
    }
    
}