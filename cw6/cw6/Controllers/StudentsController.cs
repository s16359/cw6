﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cw6.DAL;
using cw6.Models;

namespace cw6.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        

        [HttpGet]
        public IActionResult GetStudent()
        {
            IEnumerable<Student> students = _dbService.GetStudents();

            return Ok(students);
        }

        [HttpGet("enrollment/{studentId}")]
        public IActionResult GetStudentEnrollment(string studentId)
        {
            IEnumerable<Enrollment> enrollments = _dbService.GetStudentEnrollment(studentId);

            return Ok(enrollments);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            return Ok($"Updating finished. Updated id: {id}.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok($"Deleting finished. Deleted id: {id}.");
        }
    }
}