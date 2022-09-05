using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class GenericAttributeRepository : GenericRepo<GenericAttribute> , IGenericAttributeRepository
    {
        string conStr;
        public GenericAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<GenericAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByKeyGroup(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [KeyGroup] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByKey(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [Key] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [Value] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByEntityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GenericAttribute> GetByCreatedOrUpdatedDateUTC(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GenericAttribute where [CreatedOrUpdatedDateUTC] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
