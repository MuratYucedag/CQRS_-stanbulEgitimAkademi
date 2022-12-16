using CQRS_İstanbulEgitimAkademi.CQRS.Queries.StudentQueries;
using CQRS_İstanbulEgitimAkademi.CQRS.Results.StudentResults;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;
        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public GetStudentByIDQueryResult Handle(int id)
        {
            var values = _context.Students.Find(id);
            return new GetStudentByIDQueryResult
            {
                City = values.City,
                LessonAverage = values.LessonAverage,
                Name = values.Name,
                StudentID = values.StudentID,
                Surname = values.Surname
            };
        }
    }
}
