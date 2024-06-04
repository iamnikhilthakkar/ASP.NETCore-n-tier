using PetitionPulse.Core.Model.Account;
using PetitionPulse.Core.Model.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Service.Services.Account
{
    public interface IAccountService
    {
        Task<BaseResponse> Register(RegisterUserRequest request);
    }
}
