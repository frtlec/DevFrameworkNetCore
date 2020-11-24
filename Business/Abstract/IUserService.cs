using Core.Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaimDto> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

    }
}
