using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IMigrationVersionInfoRepository : IGenericRepo<MigrationVersionInfo>
    {
        List<MigrationVersionInfo> GetByVersion(long value);

        List<MigrationVersionInfo> GetByAppliedOn(Nullable<DateTime> value);

        List<MigrationVersionInfo> GetByDescription(string value);

    }
}
