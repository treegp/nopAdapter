using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ActivityLogTypeRepository : GenericRepo<ActivityLogType> , IActivityLogTypeRepository
    {
        string conStr;
        public ActivityLogTypeRepository(string connection) : base(connection) { conStr = connection; }

        public List<ActivityLogType> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLogType where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLogType> GetBySystemKeyword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLogType where [SystemKeyword] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLogType> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLogType where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLogType> GetByEnabled(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLogType where [Enabled] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
