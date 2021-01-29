using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cw6.DTO.Requests
{
    public class PromoteStudentRequest
    {
        [Required]
        public string Semester { get; set; }

        [Required]
        public string Studies { get; set; }
    }
}
