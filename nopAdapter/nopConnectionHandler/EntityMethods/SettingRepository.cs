using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SettingRepository : GenericRepo<Setting> , ISettingRepository
    {
        string conStr;
        public SettingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Setting> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Setting where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Setting> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Setting where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Setting> GetByValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Setting where [Value] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Setting> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Setting where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
