using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PollAnswerRepository : GenericRepo<PollAnswer> , IPollAnswerRepository
    {
        string conStr;
        public PollAnswerRepository(string connection) : base(connection) { conStr = connection; }

        public List<PollAnswer> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollAnswer where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollAnswer> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollAnswer where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollAnswer> GetByPollId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollAnswer where [PollId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollAnswer> GetByNumberOfVotes(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollAnswer where [NumberOfVotes] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollAnswer> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollAnswer where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
