using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AclRecordRepository : GenericRepo<AclRecord> , IAclRecordRepository
    {
        string conStr;
        public AclRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<AclRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AclRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AclRecord> GetByEntityName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AclRecord where [EntityName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AclRecord> GetByCustomerRoleId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AclRecord where [CustomerRoleId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AclRecord> GetByEntityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AclRecord where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
