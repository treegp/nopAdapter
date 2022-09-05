using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class LogRepository : GenericRepo<Log> , ILogRepository
    {
        string conStr;
        public LogRepository(string connection) : base(connection) { conStr = connection; }

        public List<Log> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByShortMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [ShortMessage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByIpAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [IpAddress] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByCustomerId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByLogLevelId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [LogLevelId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByFullMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [FullMessage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByPageUrl(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [PageUrl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByReferrerUrl(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [ReferrerUrl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Log> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Log where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
