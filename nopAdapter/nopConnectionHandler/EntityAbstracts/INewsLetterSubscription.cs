using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface INewsLetterSubscriptionRepository : IGenericRepo<NewsLetterSubscription>
    {
        List<NewsLetterSubscription> GetById(int value);

        List<NewsLetterSubscription> GetByEmail(string value);

        List<NewsLetterSubscription> GetByNewsLetterSubscriptionGuid(Guid value);

        List<NewsLetterSubscription> GetByActive(bool value);

        List<NewsLetterSubscription> GetByStoreId(int value);

        List<NewsLetterSubscription> GetByCreatedOnUtc(DateTime value);

    }
}
