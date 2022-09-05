using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class DiscountUsageHistoryRepository : GenericRepo<DiscountUsageHistory> , IDiscountUsageHistoryRepository
    {
        string conStr;
        public DiscountUsageHistoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<DiscountUsageHistory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountUsageHistory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountUsageHistory> GetByDiscountId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountUsageHistory where [DiscountId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountUsageHistory> GetByOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountUsageHistory where [OrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountUsageHistory> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountUsageHistory where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
