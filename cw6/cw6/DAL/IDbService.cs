using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw6.DTO.Requests;
using cw6.Models;

namespace cw6.DAL
{
    interface IDbService
    {
        public Student GetStudent(string indexNumber);
        public IEnumerable<Student> GetStudents();

        public IEnumerable<Enrollment> GetStudentEnrollment(string studentId);

        public Study GetStudy(string studyName);
        bool PromoteStudent(PromoteStudentRequest request);
    }
}
