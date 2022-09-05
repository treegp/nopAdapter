using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class TierPriceRepository : GenericRepo<TierPrice> , ITierPriceRepository
    {
        string conStr;
        public TierPriceRepository(string connection) : base(connection) { conStr = connection; }

        public List<TierPrice> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByCustomerRoleId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [CustomerRoleId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [Price] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByStartDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [StartDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TierPrice> GetByEndDateTimeUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TierPrice where [EndDateTimeUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
