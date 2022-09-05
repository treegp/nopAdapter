using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICampaignRepository : IGenericRepo<Campaign>
    {
        List<Campaign> GetById(int value);

        List<Campaign> GetByName(string value);

        List<Campaign> GetBySubject(string value);

        List<Campaign> GetByBody(string value);

        List<Campaign> GetByStoreId(int value);

        List<Campaign> GetByCustomerRoleId(int value);

        List<Campaign> GetByCreatedOnUtc(DateTime value);

        List<Campaign> GetByDontSendBeforeDateUtc(Nullable<DateTime> value);

    }
}
