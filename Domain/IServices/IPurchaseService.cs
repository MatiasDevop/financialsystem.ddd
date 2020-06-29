using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
    public interface IPurchaseService
    {
        void AddPurchase(Purchase purchase);
        void UpdatePurchase(Purchase purchase);
    }
}
