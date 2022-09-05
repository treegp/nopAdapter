using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShippingByWeightByTotalRecordRepository : GenericRepo<ShippingByWeightByTotalRecord> , IShippingByWeightByTotalRecordRepository
    {
        string conStr;
        public ShippingByWeightByTotalRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShippingByWeightByTotalRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByWeightFrom(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [WeightFrom] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByWeightTo(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [WeightTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByOrderSubtotalFrom(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [OrderSubtotalFrom] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByOrderSubtotalTo(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [OrderSubtotalTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByAdditionalFixedCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [AdditionalFixedCost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByPercentageRateOfSubtotal(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [PercentageRateOfSubtotal] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByRatePerWeightUnit(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [RatePerWeightUnit] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByLowerWeightLimit(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [LowerWeightLimit] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByZip(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [Zip] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByWarehouseId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [WarehouseId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByCountryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [CountryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByStateProvinceId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [StateProvinceId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByShippingMethodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [ShippingMethodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingByWeightByTotalRecord> GetByTransitDays(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingByWeightByTotalRecord where [TransitDays] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
