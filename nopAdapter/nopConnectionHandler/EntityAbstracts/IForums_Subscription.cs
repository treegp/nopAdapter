using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_SubscriptionRepository : IGenericRepo<Forums_Subscription>
    {
        List<Forums_Subscription> GetById(int value);

        List<Forums_Subscription> GetByCustomerId(int value);

        List<Forums_Subscription> GetBySubscriptionGuid(Guid value);

        List<Forums_Subscription> GetByForumId(int value);

        List<Forums_Subscription> GetByTopicId(int value);

        List<Forums_Subscription> GetByCreatedOnUtc(DateTime value);

    }
}
