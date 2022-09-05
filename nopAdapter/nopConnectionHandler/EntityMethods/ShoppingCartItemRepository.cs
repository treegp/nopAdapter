using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShoppingCartItemRepository : GenericRepo<ShoppingCartItem> , IShoppingCartItemRepository
    {
        string conStr;
        public ShoppingCartItemRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShoppingCartItem> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByShoppingCartTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [ShoppingCartTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByAttributesXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [AttributesXml] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByCustomerEnteredPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [CustomerEnteredPrice] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByRentalStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [RentalStartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByRentalEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [RentalEndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItem> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItem where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
