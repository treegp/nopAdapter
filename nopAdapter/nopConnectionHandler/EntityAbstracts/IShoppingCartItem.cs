using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShoppingCartItemRepository : IGenericRepo<ShoppingCartItem>
    {
        List<ShoppingCartItem> GetById(int value);

        List<ShoppingCartItem> GetByCustomerId(int value);

        List<ShoppingCartItem> GetByProductId(int value);

        List<ShoppingCartItem> GetByStoreId(int value);

        List<ShoppingCartItem> GetByShoppingCartTypeId(int value);

        List<ShoppingCartItem> GetByAttributesXml(string value);

        List<ShoppingCartItem> GetByCustomerEnteredPrice(decimal value);

        List<ShoppingCartItem> GetByQuantity(int value);

        List<ShoppingCartItem> GetByRentalStartDateUtc(Nullable<DateTime> value);

        List<ShoppingCartItem> GetByRentalEndDateUtc(Nullable<DateTime> value);

        List<ShoppingCartItem> GetByCreatedOnUtc(DateTime value);

        List<ShoppingCartItem> GetByUpdatedOnUtc(DateTime value);

    }
}
