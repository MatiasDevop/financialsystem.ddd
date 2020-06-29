using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category);
    }
}
