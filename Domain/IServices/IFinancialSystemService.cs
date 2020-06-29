using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
    public interface IFinancialSystemService
    {
        void AddFinancialSystem(FinancialSystem financialSystem);
        void UpdateFinancialSystem(FinancialSystem financialSystem);
    }
}
