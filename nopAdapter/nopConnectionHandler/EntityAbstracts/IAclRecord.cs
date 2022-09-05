using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IAclRecordRepository : IGenericRepo<AclRecord>
    {
        List<AclRecord> GetById(int value);

        List<AclRecord> GetByEntityName(string value);

        List<AclRecord> GetByCustomerRoleId(int value);

        List<AclRecord> GetByEntityId(int value);

    }
}
