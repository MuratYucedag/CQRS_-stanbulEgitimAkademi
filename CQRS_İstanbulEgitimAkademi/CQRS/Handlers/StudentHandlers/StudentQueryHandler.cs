using CQRS_İstanbulEgitimAkademi.CQRS.Results.StudentResults;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class StudentQueryHandler
    {
        private readonly ProductContext _context;
        public StudentQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public List<GetStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetStudentQueryResult
            {
                StudentID = x.StudentID,
                Name = x.Name,
                Surname = x.Surname,
                Aaaa = x.City
            }).ToList();
            return values;
        }
    }
}
