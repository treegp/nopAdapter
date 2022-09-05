using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PollRepository : GenericRepo<Poll> , IPollRepository
    {
        string conStr;
        public PollRepository(string connection) : base(connection) { conStr = connection; }

        public List<Poll> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetBySystemKeyword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [SystemKeyword] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByShowOnHomepage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [ShowOnHomepage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByAllowGuestsToVote(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [AllowGuestsToVote] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [StartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Poll> GetByEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Poll where [EndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
