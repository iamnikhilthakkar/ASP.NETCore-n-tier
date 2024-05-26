using PetitionPulse.Repository.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Repository.Repositories.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly PetitionPulseContext _context;
        public AccountRepository(PetitionPulseContext context)
        {
            _context = context;
        }
    }
}
