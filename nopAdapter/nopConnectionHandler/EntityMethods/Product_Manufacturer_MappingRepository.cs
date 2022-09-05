using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_Manufacturer_MappingRepository : GenericRepo<Product_Manufacturer_Mapping> , IProduct_Manufacturer_MappingRepository
    {
        string conStr;
        public Product_Manufacturer_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_Manufacturer_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Manufacturer_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Manufacturer_Mapping> GetByManufacturerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Manufacturer_Mapping where [ManufacturerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Manufacturer_Mapping> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Manufacturer_Mapping where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Manufacturer_Mapping> GetByIsFeaturedProduct(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Manufacturer_Mapping where [IsFeaturedProduct] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Manufacturer_Mapping> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Manufacturer_Mapping where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
