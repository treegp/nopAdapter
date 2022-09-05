using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_ProductTag_MappingRepository : GenericRepo<Product_ProductTag_Mapping> , IProduct_ProductTag_MappingRepository
    {
        string conStr;
        public Product_ProductTag_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_ProductTag_Mapping> GetByProduct_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductTag_Mapping where [Product_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductTag_Mapping> GetByProductTag_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductTag_Mapping where [ProductTag_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
