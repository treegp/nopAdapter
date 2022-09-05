using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerRoleRepository : GenericRepo<CustomerRole> , ICustomerRoleRepository
    {
        string conStr;
        public CustomerRoleRepository(string connection) : base(connection) { conStr = connection; }

        public List<CustomerRole> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetBySystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [SystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByFreeShipping(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [FreeShipping] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByTaxExempt(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [TaxExempt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [Active] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByIsSystemRole(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [IsSystemRole] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByEnablePasswordLifetime(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [EnablePasswordLifetime] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByOverrideTaxDisplayType(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [OverrideTaxDisplayType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByDefaultTaxDisplayTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [DefaultTaxDisplayTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerRole> GetByPurchasedWithProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerRole where [PurchasedWithProductId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
