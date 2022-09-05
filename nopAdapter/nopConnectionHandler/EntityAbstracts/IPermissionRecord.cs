using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPermissionRecordRepository : IGenericRepo<PermissionRecord>
    {
        List<PermissionRecord> GetById(int value);

        List<PermissionRecord> GetByName(string value);

        List<PermissionRecord> GetBySystemName(string value);

        List<PermissionRecord> GetByCategory(string value);

    }
}
