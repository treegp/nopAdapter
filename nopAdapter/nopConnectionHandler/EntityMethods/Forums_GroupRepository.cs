using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_GroupRepository : GenericRepo<Forums_Group> , IForums_GroupRepository
    {
        string conStr;
        public Forums_GroupRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_Group> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Group where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Group> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Group where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Group> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Group where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Group> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Group where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Group> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Group where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
