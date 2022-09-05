using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ActivityLogRepository : GenericRepo<ActivityLog> , IActivityLogRepository
    {
        string conStr;
        public ActivityLogRepository(string connection) : base(connection) { conStr = connection; }

        public List<ActivityLog> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [Comment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByIpAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [IpAddress] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByEntityName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [EntityName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByActivityLogTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [ActivityLogTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByEntityId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ActivityLog> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ActivityLog where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
