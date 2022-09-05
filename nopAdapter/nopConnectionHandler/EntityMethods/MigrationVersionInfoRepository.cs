using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class MigrationVersionInfoRepository : GenericRepo<MigrationVersionInfo> , IMigrationVersionInfoRepository
    {
        string conStr;
        public MigrationVersionInfoRepository(string connection) : base(connection) { conStr = connection; }

        public List<MigrationVersionInfo> GetByVersion(long value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MigrationVersionInfo where [Version] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MigrationVersionInfo> GetByAppliedOn(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MigrationVersionInfo where [AppliedOn] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MigrationVersionInfo> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MigrationVersionInfo where [Description] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
