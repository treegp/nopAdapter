using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ILogRepository : IGenericRepo<Log>
    {
        List<Log> GetById(int value);

        List<Log> GetByShortMessage(string value);

        List<Log> GetByIpAddress(string value);

        List<Log> GetByCustomerId(Nullable<int> value);

        List<Log> GetByLogLevelId(int value);

        List<Log> GetByFullMessage(string value);

        List<Log> GetByPageUrl(string value);

        List<Log> GetByReferrerUrl(string value);

        List<Log> GetByCreatedOnUtc(DateTime value);

    }
}
