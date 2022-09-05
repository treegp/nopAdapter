using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ITierPriceRepository : IGenericRepo<TierPrice>
    {
        List<TierPrice> GetById(int value);

        List<TierPrice> GetByCustomerRoleId(Nullable<int> value);

        List<TierPrice> GetByProductId(int value);

        List<TierPrice> GetByStoreId(int value);

        List<TierPrice> GetByQuantity(int value);

        List<TierPrice> GetByPrice(decimal value);

        List<TierPrice> GetByStartDateTimeUtc(Nullable<DateTime> value);

        List<TierPrice> GetByEndDateTimeUtc(Nullable<DateTime> value);

    }
}
