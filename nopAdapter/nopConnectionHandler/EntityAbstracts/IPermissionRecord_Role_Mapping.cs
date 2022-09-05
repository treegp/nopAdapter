using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPermissionRecord_Role_MappingRepository : IGenericRepo<PermissionRecord_Role_Mapping>
    {
        List<PermissionRecord_Role_Mapping> GetByPermissionRecord_Id(int value);

        List<PermissionRecord_Role_Mapping> GetByCustomerRole_Id(int value);

    }
}
