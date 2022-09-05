using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGdprLogRepository : IGenericRepo<GdprLog>
    {
        List<GdprLog> GetById(int value);

        List<GdprLog> GetByCustomerId(int value);

        List<GdprLog> GetByConsentId(int value);

        List<GdprLog> GetByCustomerInfo(string value);

        List<GdprLog> GetByRequestTypeId(int value);

        List<GdprLog> GetByRequestDetails(string value);

        List<GdprLog> GetByCreatedOnUtc(DateTime value);

    }
}
