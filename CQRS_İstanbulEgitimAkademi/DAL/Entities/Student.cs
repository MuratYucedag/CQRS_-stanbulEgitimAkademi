using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.DAL.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }
        public decimal? LessonAverage { get; set; }
        public string Image { get; set; }
    }
}
