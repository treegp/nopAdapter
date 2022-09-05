using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CheckoutAttributeValueRepository : GenericRepo<CheckoutAttributeValue> , ICheckoutAttributeValueRepository
    {
        string conStr;
        public CheckoutAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<CheckoutAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByColorSquaresRgb(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [ColorSquaresRgb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByCheckoutAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [CheckoutAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByPriceAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [PriceAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByWeightAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [WeightAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
