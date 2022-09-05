using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAffiliateRepository : IGenericRepo<Affiliate>
    {
        List<Affiliate> GetById(int value);

        List<Affiliate> GetByAddressId(int value);

        List<Affiliate> GetByAdminComment(string value);

        List<Affiliate> GetByFriendlyUrlName(string value);

        List<Affiliate> GetByDeleted(bool value);

        List<Affiliate> GetByActive(bool value);

    }
}
