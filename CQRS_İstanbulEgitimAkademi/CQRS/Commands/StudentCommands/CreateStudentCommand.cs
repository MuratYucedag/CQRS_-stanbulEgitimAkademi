using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand
    {
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentDepartment { get; set; }
    }
}
