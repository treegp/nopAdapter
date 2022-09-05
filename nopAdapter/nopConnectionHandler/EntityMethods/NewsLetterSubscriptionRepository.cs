using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class NewsLetterSubscriptionRepository : GenericRepo<NewsLetterSubscription> , INewsLetterSubscriptionRepository
    {
        string conStr;
        public NewsLetterSubscriptionRepository(string connection) : base(connection) { conStr = connection; }

        public List<NewsLetterSubscription> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsLetterSubscription> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsLetterSubscription> GetByNewsLetterSubscriptionGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [NewsLetterSubscriptionGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsLetterSubscription> GetByActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [Active] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsLetterSubscription> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsLetterSubscription> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsLetterSubscription where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
