using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_ForumRepository : GenericRepo<Forums_Forum> , IForums_ForumRepository
    {
        string conStr;
        public Forums_ForumRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_Forum> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByForumGroupId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [ForumGroupId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByNumTopics(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [NumTopics] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByNumPosts(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [NumPosts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByLastTopicId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [LastTopicId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByLastPostId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [LastPostId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByLastPostCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [LastPostCustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByLastPostTime(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [LastPostTime] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Forum> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Forum where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
