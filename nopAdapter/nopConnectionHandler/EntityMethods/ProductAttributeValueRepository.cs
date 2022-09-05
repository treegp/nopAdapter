using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductAttributeValueRepository : GenericRepo<ProductAttributeValue> , IProductAttributeValueRepository
    {
        string conStr;
        public ProductAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByColorSquaresRgb(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [ColorSquaresRgb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByProductAttributeMappingId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [ProductAttributeMappingId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByAttributeValueTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [AttributeValueTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByAssociatedProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [AssociatedProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByImageSquaresPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [ImageSquaresPictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByPriceAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [PriceAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByPriceAdjustmentUsePercentage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [PriceAdjustmentUsePercentage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByWeightAdjustment(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [WeightAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [Cost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByCustomerEntersQty(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [CustomerEntersQty] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeValue> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeValue where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
