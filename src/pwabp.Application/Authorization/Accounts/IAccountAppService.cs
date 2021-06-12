﻿using System.Threading.Tasks;
using Abp.Application.Services;
using pwabp.Authorization.Accounts.Dto;

namespace pwabp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
