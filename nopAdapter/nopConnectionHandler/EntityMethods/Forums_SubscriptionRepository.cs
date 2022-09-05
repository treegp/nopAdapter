using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_SubscriptionRepository : GenericRepo<Forums_Subscription> , IForums_SubscriptionRepository
    {
        string conStr;
        public Forums_SubscriptionRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_Subscription> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Subscription> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Subscription> GetBySubscriptionGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [SubscriptionGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Subscription> GetByForumId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [ForumId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Subscription> GetByTopicId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [TopicId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_Subscription> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_Subscription where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
