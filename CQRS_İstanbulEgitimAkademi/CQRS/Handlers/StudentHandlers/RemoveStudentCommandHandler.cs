using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;
        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(int id)
        {
            var values = _context.Students.Find(id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
