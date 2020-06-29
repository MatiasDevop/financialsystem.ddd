using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
    public interface IUserFinancialSystemService
    {
        void RegisterUserOnSystem(UserFinancialSystem userFinancialSytem);
    }
}
