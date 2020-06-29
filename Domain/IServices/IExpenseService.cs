using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
   public interface IExpenseService
    {
        void AddExpense(Expense expense);
        void updateExpense(Expense expense);
    }
}
