using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_TopicRepository : GenericRepo<Forums_Topic> , IForums_TopicRepository
    {
        string conStr;
        public Forums_TopicRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_Topic> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetBySubject(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [Subject] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByForumId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [ForumId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByTopicTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [TopicTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByNumPosts(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [NumPosts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByViews(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [Views] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByLastPostId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [LastPostId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByLastPostCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [LastPostCustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByLastPostTime(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [LastPostTime] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Topic> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Topic where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
