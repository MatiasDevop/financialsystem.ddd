using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IItemPurchase : IGeneric<ItemPurchase>
    {
        void UpdateItemPurchase(ItemPurchase ItemPurchase);
        void DeleteItemById(int Id);
        IList<ItemPurchase> ListItemsByPurchase(int IdPurchase);
    }
}
