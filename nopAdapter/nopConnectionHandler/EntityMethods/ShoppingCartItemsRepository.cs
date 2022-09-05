using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShoppingCartItemsRepository : GenericRepo<ShoppingCartItems> , IShoppingCartItemsRepository
    {
        string conStr;
        public ShoppingCartItemsRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShoppingCartItems> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItems where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItems> GetByRow(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItems where [Row] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItems> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItems where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItems> GetByCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItems where [Cost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShoppingCartItems> GetByShoppingCartId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShoppingCartItems where [ShoppingCartId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
