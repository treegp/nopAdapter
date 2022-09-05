using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductAttributeCombinationRepository : GenericRepo<ProductAttributeCombination> , IProductAttributeCombinationRepository
    {
        string conStr;
        public ProductAttributeCombinationRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductAttributeCombination> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetBySku(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [Sku] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByManufacturerPartNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [ManufacturerPartNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByGtin(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [Gtin] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByAttributesXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [AttributesXml] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [StockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByAllowOutOfStockOrders(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [AllowOutOfStockOrders] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByOverriddenPrice(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [OverriddenPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByNotifyAdminForQuantityBelow(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [NotifyAdminForQuantityBelow] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttributeCombination> GetByMinStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttributeCombination where [MinStockQuantity] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
