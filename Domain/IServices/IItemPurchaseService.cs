using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IServices
{
    public interface IItemPurchaseService
    {
        void AddItemPurchase(ItemPurchase ItemPurchase);
        void UpdateItemPurchase(ItemPurchase ItemPurchase);
    }
}
