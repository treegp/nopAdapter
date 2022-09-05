using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_PostRepository : GenericRepo<Forums_Post> , IForums_PostRepository
    {
        string conStr;
        public Forums_PostRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_Post> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [Text] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByIPAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [IPAddress] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByTopicId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [TopicId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Post> GetByVoteCount(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Post where [VoteCount] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
