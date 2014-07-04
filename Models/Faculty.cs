using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        [Range(0, 130)]
        public int Vacancies { get; set; }
        [Range(0, 70)]
        public int ScholarshipVacancies { get; set; }
    }
}
