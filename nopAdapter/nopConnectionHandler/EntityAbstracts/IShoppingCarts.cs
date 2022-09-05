using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShoppingCartsRepository : IGenericRepo<ShoppingCarts>
    {
        List<ShoppingCarts> GetById(int value);

        List<ShoppingCarts> GetByCostumerId(int value);

        List<ShoppingCarts> GetByCreatedDate(DateTimeOffset value);

        List<ShoppingCarts> GetByStatus(int value);

        List<ShoppingCarts> GetByTotalCost(decimal value);

    }
}
