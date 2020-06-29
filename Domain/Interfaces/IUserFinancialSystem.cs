using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUserFinancialSystem : IGeneric<UserFinancialSystem>
    {
        IList<UserFinancialSystem> ListUsersSystem(int IdSystem);
        void RemoveUsers(List<UserFinancialSystem> users);
        UserFinancialSystem GetUserByEmail(string userEmail);
    }
}
