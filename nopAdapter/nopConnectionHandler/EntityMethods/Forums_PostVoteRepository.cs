using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_PostVoteRepository : GenericRepo<Forums_PostVote> , IForums_PostVoteRepository
    {
        string conStr;
        public Forums_PostVoteRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_PostVote> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PostVote where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PostVote> GetByForumPostId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PostVote where [ForumPostId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PostVote> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PostVote where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PostVote> GetByIsUp(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PostVote where [IsUp] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PostVote> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PostVote where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
