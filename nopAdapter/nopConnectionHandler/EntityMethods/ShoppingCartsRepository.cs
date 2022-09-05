using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShoppingCartsRepository : GenericRepo<ShoppingCarts> , IShoppingCartsRepository
    {
        string conStr;
        public ShoppingCartsRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShoppingCarts> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCarts where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCarts> GetByCostumerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCarts where [CostumerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCarts> GetByCreatedDate(DateTimeOffset value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCarts where [CreatedDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCarts> GetByStatus(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCarts where [Status] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCarts> GetByTotalCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCarts where [TotalCost] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
