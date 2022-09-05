using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGiftCardUsageHistoryRepository : IGenericRepo<GiftCardUsageHistory>
    {
        List<GiftCardUsageHistory> GetById(int value);

        List<GiftCardUsageHistory> GetByGiftCardId(int value);

        List<GiftCardUsageHistory> GetByUsedWithOrderId(int value);

        List<GiftCardUsageHistory> GetByUsedValue(decimal value);

        List<GiftCardUsageHistory> GetByCreatedOnUtc(DateTime value);

    }
}
