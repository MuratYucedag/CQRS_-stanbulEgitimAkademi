using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.DAL.Entities
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public string Gender { get; set; }
    }
}
