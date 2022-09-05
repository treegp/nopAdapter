using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CheckoutAttributeRepository : GenericRepo<CheckoutAttribute> , ICheckoutAttributeRepository
    {
        string conStr;
        public CheckoutAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<CheckoutAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByTextPrompt(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [TextPrompt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByShippableProductRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ShippableProductRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByIsTaxExempt(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [IsTaxExempt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByTaxCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [TaxCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByAttributeControlTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [AttributeControlTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByValidationMinLength(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ValidationMinLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByValidationMaxLength(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ValidationMaxLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByValidationFileAllowedExtensions(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ValidationFileAllowedExtensions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByValidationFileMaximumSize(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ValidationFileMaximumSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByDefaultValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [DefaultValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CheckoutAttribute> GetByConditionAttributeXml(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CheckoutAttribute where [ConditionAttributeXml] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
