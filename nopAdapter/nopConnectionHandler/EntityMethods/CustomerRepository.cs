using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerRepository : GenericRepo<Customer> , ICustomerRepository
    {
        string conStr;
        public CustomerRepository(string connection) : base(connection) { conStr = connection; }

        public List<Customer> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByUsername(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [Username] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByEmailToRevalidate(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [EmailToRevalidate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetBySystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [SystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByBillingAddress_Id(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [BillingAddress_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByShippingAddress_Id(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [ShippingAddress_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByCustomerGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [CustomerGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByIsTaxExempt(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [IsTaxExempt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByAffiliateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [AffiliateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByVendorId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [VendorId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByHasShoppingCartItems(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [HasShoppingCartItems] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByRequireReLogin(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [RequireReLogin] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByFailedLoginAttempts(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [FailedLoginAttempts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByCannotLoginUntilDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [CannotLoginUntilDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [Active] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByIsSystemAccount(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [IsSystemAccount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByLastIpAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [LastIpAddress] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByLastLoginDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [LastLoginDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByLastActivityDateUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [LastActivityDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer> GetByRegisteredInStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer where [RegisteredInStoreId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
