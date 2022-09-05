using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PredefinedProductAttributeValueRepository : GenericRepo<PredefinedProductAttributeValue> , IPredefinedProductAttributeValueRepository
    {
        string conStr;
        public PredefinedProductAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<PredefinedProductAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByProductAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [ProductAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByPriceAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [PriceAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByPriceAdjustmentUsePercentage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [PriceAdjustmentUsePercentage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByWeightAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [WeightAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [Cost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PredefinedProductAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PredefinedProductAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
