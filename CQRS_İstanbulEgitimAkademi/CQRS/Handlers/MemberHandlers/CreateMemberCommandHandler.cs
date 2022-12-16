using CQRS_İstanbulEgitimAkademi.CQRS.Commands.MemberCommands;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using CQRS_İstanbulEgitimAkademi.DAL.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.MemberHandlers
{
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly ProductContext _context;
        public CreateMemberCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            await _context.Members.AddAsync(new Member
            {
                Name = request.Name,
                Surname = request.Surname,
                City = request.City
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
