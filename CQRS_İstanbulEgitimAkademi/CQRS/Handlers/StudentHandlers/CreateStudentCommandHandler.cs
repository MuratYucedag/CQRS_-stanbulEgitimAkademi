using CQRS_İstanbulEgitimAkademi.CQRS.Commands.StudentCommands;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using CQRS_İstanbulEgitimAkademi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;
        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.studentName,
                Surname = command.studentSurname,
                Department = command.studentDepartment
            });
            _context.SaveChanges();
        }
    }
}
