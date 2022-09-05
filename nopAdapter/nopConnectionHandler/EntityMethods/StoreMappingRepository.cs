using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class StoreMappingRepository : GenericRepo<StoreMapping> , IStoreMappingRepository
    {
        string conStr;
        public StoreMappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<StoreMapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StoreMapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StoreMapping> GetByEntityName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StoreMapping where [EntityName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StoreMapping> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StoreMapping where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StoreMapping> GetByEntityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StoreMapping where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
