using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IActivityLogTypeRepository : IGenericRepo<ActivityLogType>
    {
        List<ActivityLogType> GetById(int value);

        List<ActivityLogType> GetBySystemKeyword(string value);

        List<ActivityLogType> GetByName(string value);

        List<ActivityLogType> GetByEnabled(bool value);

    }
}
