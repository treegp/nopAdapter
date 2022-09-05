using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_Category_MappingRepository : GenericRepo<Product_Category_Mapping> , IProduct_Category_MappingRepository
    {
        string conStr;
        public Product_Category_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_Category_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Category_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Category_Mapping> GetByCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Category_Mapping where [CategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Category_Mapping> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Category_Mapping where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Category_Mapping> GetByIsFeaturedProduct(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Category_Mapping where [IsFeaturedProduct] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Category_Mapping> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Category_Mapping where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
