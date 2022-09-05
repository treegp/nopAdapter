using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ScheduleTaskRepository : GenericRepo<ScheduleTask> , IScheduleTaskRepository
    {
        string conStr;
        public ScheduleTaskRepository(string connection) : base(connection) { conStr = connection; }

        public List<ScheduleTask> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [Type] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetBySeconds(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [Seconds] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByLastEnabledUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [LastEnabledUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByEnabled(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [Enabled] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByStopOnError(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [StopOnError] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByLastStartUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [LastStartUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByLastEndUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [LastEndUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ScheduleTask> GetByLastSuccessUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ScheduleTask where [LastSuccessUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
