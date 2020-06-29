using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IExpense : IGeneric<Expense>
    {
        IList<Expense> ListExpensesUser(string userEmail);
        IList<Expense> ListExpenseUserNoPayedLastMonths(string userEmail);
    }
}
