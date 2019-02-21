using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.API.Data.Interfaces;
using SchoolManagementSystem.API.Data.Models.Entities;
using SchoolManagementSystem.API.Dtos;

namespace SchoolManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var studentsFromRepo = await _repo.GetStudents();
            var studentToReturn = _mapper.Map<IEnumerable<StudentsToReturnDto>>(studentsFromRepo);

            return Ok(studentToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentsForReturnDto studentsForReturnDto)
        {
            var studentsToReturn = _mapper.Map<Student>(studentsForReturnDto);
            _repo.Add(studentsToReturn);

            if(await _repo.SaveAll())
                return NoContent();

            return BadRequest("Could not Add the Student");
        }
    }
}