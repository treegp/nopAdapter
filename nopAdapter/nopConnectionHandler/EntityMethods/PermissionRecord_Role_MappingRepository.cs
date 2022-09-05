using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PermissionRecord_Role_MappingRepository : GenericRepo<PermissionRecord_Role_Mapping> , IPermissionRecord_Role_MappingRepository
    {
        string conStr;
        public PermissionRecord_Role_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<PermissionRecord_Role_Mapping> GetByPermissionRecord_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord_Role_Mapping where [PermissionRecord_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PermissionRecord_Role_Mapping> GetByCustomerRole_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord_Role_Mapping where [CustomerRole_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
