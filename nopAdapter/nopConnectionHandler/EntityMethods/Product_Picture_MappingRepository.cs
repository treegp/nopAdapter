using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_Picture_MappingRepository : GenericRepo<Product_Picture_Mapping> , IProduct_Picture_MappingRepository
    {
        string conStr;
        public Product_Picture_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_Picture_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Picture_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Picture_Mapping> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Picture_Mapping where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Picture_Mapping> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Picture_Mapping where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_Picture_Mapping> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_Picture_Mapping where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
