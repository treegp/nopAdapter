using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_SpecificationAttribute_MappingRepository : GenericRepo<Product_SpecificationAttribute_Mapping> , IProduct_SpecificationAttribute_MappingRepository
    {
        string conStr;
        public Product_SpecificationAttribute_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_SpecificationAttribute_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByCustomValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [CustomValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetBySpecificationAttributeOptionId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [SpecificationAttributeOptionId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByAttributeTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [AttributeTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByAllowFiltering(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [AllowFiltering] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByShowOnProductPage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [ShowOnProductPage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_SpecificationAttribute_Mapping> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_SpecificationAttribute_Mapping where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
