using CQRS_İstanbulEgitimAkademi.CQRS.Results.MemberResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Queries.MemberQueries
{
    public class GetAllMemberQuery : IRequest<List<GetAllMemberResult>>
    {
    }
}
