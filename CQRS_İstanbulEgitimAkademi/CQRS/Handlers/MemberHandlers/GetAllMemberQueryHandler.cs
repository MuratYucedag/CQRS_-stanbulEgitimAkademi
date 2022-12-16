using CQRS_İstanbulEgitimAkademi.CQRS.Queries.MemberQueries;
using CQRS_İstanbulEgitimAkademi.CQRS.Results.MemberResults;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.MemberHandlers
{
    public class GetAllMemberQueryHandler:IRequestHandler<GetAllMemberQuery,List<GetAllMemberResult>>
    {
        private readonly ProductContext _context;
        public GetAllMemberQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllMemberResult>> Handle(GetAllMemberQuery request, CancellationToken cancellationToken)
        {
            return await _context.Members.Select(x =>
            new GetAllMemberResult
            {
                City = x.City,
                MemberID = x.MemberID,
                Name = x.Name,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}
