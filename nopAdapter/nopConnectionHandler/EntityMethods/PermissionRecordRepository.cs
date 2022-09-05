using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PermissionRecordRepository : GenericRepo<PermissionRecord> , IPermissionRecordRepository
    {
        string conStr;
        public PermissionRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<PermissionRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PermissionRecord> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PermissionRecord> GetBySystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord where [SystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PermissionRecord> GetByCategory(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PermissionRecord where [Category] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
