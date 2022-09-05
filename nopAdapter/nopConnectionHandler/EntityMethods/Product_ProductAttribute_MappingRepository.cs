using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Product_ProductAttribute_MappingRepository : GenericRepo<Product_ProductAttribute_Mapping> , IProduct_ProductAttribute_MappingRepository
    {
        string conStr;
        public Product_ProductAttribute_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Product_ProductAttribute_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByProductAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ProductAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByTextPrompt(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [TextPrompt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByAttributeControlTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [AttributeControlTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByValidationMinLength(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ValidationMinLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByValidationMaxLength(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ValidationMaxLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByValidationFileAllowedExtensions(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ValidationFileAllowedExtensions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByValidationFileMaximumSize(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ValidationFileMaximumSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByDefaultValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [DefaultValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Product_ProductAttribute_Mapping> GetByConditionAttributeXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Product_ProductAttribute_Mapping where [ConditionAttributeXml] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
