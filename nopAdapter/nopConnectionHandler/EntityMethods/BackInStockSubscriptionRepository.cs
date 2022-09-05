using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class BackInStockSubscriptionRepository : GenericRepo<BackInStockSubscription> , IBackInStockSubscriptionRepository
    {
        string conStr;
        public BackInStockSubscriptionRepository(string connection) : base(connection) { conStr = connection; }

        public List<BackInStockSubscription> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BackInStockSubscription where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BackInStockSubscription> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BackInStockSubscription where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BackInStockSubscription> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BackInStockSubscription where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BackInStockSubscription> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BackInStockSubscription where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BackInStockSubscription> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BackInStockSubscription where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
