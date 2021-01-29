using cw6.Models;
using cw6.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw6.Services
{
    public interface IStudentsDbService
    {
        public bool PromoteStudentRequest(PromoteStudentRequest promoteStudentRequest);

        public StudentEnrollment EnrollStudent(EnrollStudentRequest enrollStudentRequest);

        public Study GetStudy(string studyName);
        bool PromoteStudent(PromoteStudentRequest request);
    }
}
