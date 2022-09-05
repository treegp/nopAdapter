using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShoppingCartItemsRepository : IGenericRepo<ShoppingCartItems>
    {
        List<ShoppingCartItems> GetById(int value);

        List<ShoppingCartItems> GetByRow(int value);

        List<ShoppingCartItems> GetByProductId(int value);

        List<ShoppingCartItems> GetByCost(decimal value);

        List<ShoppingCartItems> GetByShoppingCartId(int value);

    }
}
