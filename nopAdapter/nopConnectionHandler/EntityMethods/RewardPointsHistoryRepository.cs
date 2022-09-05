using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class RewardPointsHistoryRepository : GenericRepo<RewardPointsHistory> , IRewardPointsHistoryRepository
    {
        string conStr;
        public RewardPointsHistoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<RewardPointsHistory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByPoints(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [Points] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByPointsBalance(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [PointsBalance] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByUsedAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [UsedAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [Message] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [EndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByValidPoints(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [ValidPoints] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RewardPointsHistory> GetByUsedWithOrder(Nullable<Guid> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RewardPointsHistory where [UsedWithOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
