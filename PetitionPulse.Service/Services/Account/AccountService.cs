using AutoMapper;

using PetitionPulse.Core.Model.Account;
using PetitionPulse.Core.Model.Common;
using PetitionPulse.Repository.Repositories.Account;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Service.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Register(RegisterUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
