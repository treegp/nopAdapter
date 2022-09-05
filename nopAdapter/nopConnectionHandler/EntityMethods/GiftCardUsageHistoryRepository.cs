using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class GiftCardUsageHistoryRepository : GenericRepo<GiftCardUsageHistory> , IGiftCardUsageHistoryRepository
    {
        string conStr;
        public GiftCardUsageHistoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<GiftCardUsageHistory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCardUsageHistory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCardUsageHistory> GetByGiftCardId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCardUsageHistory where [GiftCardId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCardUsageHistory> GetByUsedWithOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCardUsageHistory where [UsedWithOrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCardUsageHistory> GetByUsedValue(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCardUsageHistory where [UsedValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCardUsageHistory> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCardUsageHistory where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
