using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductsRepository : GenericRepo<Products> , IProductsRepository
    {
        string conStr;
        public ProductsRepository(string connection) : base(connection) { conStr = connection; }

        public List<Products> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [CategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Price] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
