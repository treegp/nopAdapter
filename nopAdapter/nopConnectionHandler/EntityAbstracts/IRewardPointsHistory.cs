using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IRewardPointsHistoryRepository : IGenericRepo<RewardPointsHistory>
    {
        List<RewardPointsHistory> GetById(int value);

        List<RewardPointsHistory> GetByCustomerId(int value);

        List<RewardPointsHistory> GetByStoreId(int value);

        List<RewardPointsHistory> GetByPoints(int value);

        List<RewardPointsHistory> GetByPointsBalance(Nullable<int> value);

        List<RewardPointsHistory> GetByUsedAmount(decimal value);

        List<RewardPointsHistory> GetByMessage(string value);

        List<RewardPointsHistory> GetByCreatedOnUtc(DateTime value);

        List<RewardPointsHistory> GetByEndDateUtc(Nullable<DateTime> value);

        List<RewardPointsHistory> GetByValidPoints(Nullable<int> value);

        List<RewardPointsHistory> GetByUsedWithOrder(Nullable<Guid> value);

    }
}
