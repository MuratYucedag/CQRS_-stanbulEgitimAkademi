using CQRS_İstanbulEgitimAkademi.CQRS.Commands.StudentCommands;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;
        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.LessonAverage = command.LessonAverage;
            values.City = command.City;
            _context.SaveChanges();
        }
    }
}
