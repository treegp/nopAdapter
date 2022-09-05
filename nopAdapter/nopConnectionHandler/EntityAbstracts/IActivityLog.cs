using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IActivityLogRepository : IGenericRepo<ActivityLog>
    {
        List<ActivityLog> GetById(int value);

        List<ActivityLog> GetByComment(string value);

        List<ActivityLog> GetByIpAddress(string value);

        List<ActivityLog> GetByEntityName(string value);

        List<ActivityLog> GetByActivityLogTypeId(int value);

        List<ActivityLog> GetByCustomerId(int value);

        List<ActivityLog> GetByEntityId(Nullable<int> value);

        List<ActivityLog> GetByCreatedOnUtc(DateTime value);

    }
}
