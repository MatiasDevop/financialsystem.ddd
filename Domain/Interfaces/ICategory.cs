using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Generics
{
    public interface ICategory : IGeneric<Category>
    {
        IList<Category> ListUserCategory(string userEmail);
    }
}
