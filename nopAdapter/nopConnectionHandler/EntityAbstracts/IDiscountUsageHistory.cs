using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscountUsageHistoryRepository : IGenericRepo<DiscountUsageHistory>
    {
        List<DiscountUsageHistory> GetById(int value);

        List<DiscountUsageHistory> GetByDiscountId(int value);

        List<DiscountUsageHistory> GetByOrderId(int value);

        List<DiscountUsageHistory> GetByCreatedOnUtc(DateTime value);

    }
}
