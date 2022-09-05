using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class OrderItemRepository : GenericRepo<OrderItem> , IOrderItemRepository
    {
        string conStr;
        public OrderItemRepository(string connection) : base(connection) { conStr = connection; }

        public List<OrderItem> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [OrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByOrderItemGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [OrderItemGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByUnitPriceInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [UnitPriceInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByUnitPriceExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [UnitPriceExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByPriceInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [PriceInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByPriceExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [PriceExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByDiscountAmountInclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [DiscountAmountInclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByDiscountAmountExclTax(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [DiscountAmountExclTax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByOriginalProductCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [OriginalProductCost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByAttributeDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [AttributeDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByAttributesXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [AttributesXml] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByDownloadCount(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [DownloadCount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByIsDownloadActivated(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [IsDownloadActivated] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByLicenseDownloadId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [LicenseDownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByItemWeight(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [ItemWeight] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByRentalStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [RentalStartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderItem> GetByRentalEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderItem where [RentalEndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
