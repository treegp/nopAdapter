using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IBackInStockSubscriptionRepository : IGenericRepo<BackInStockSubscription>
    {
        List<BackInStockSubscription> GetById(int value);

        List<BackInStockSubscription> GetByCustomerId(int value);

        List<BackInStockSubscription> GetByProductId(int value);

        List<BackInStockSubscription> GetByStoreId(int value);

        List<BackInStockSubscription> GetByCreatedOnUtc(DateTime value);

    }
}
