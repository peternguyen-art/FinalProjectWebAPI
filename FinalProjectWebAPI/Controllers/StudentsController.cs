using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWebAPI.Data;
using FinalProjectWebAPI.Models;

namespace FinalProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly FinalProjectWebAPIContext _context;

        public StudentsController(FinalProjectWebAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            var students = _context.Student.ToList();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Student student = _context.Student.Find(id);
            if (student == null || id == 0)
            {
                List<Student> firstFiveStudents = _context.Student.Take(5).ToList();
                return Ok(firstFiveStudents);
            }
            else
                return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            try
            {
                _context.Student.Add(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            try
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult PutStudent(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
