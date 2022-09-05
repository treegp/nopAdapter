using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerPasswordRepository : GenericRepo<CustomerPassword> , ICustomerPasswordRepository
    {
        string conStr;
        public CustomerPasswordRepository(string connection) : base(connection) { conStr = connection; }

        public List<CustomerPassword> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerPassword> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerPassword> GetByPassword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [Password] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerPassword> GetByPasswordFormatId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [PasswordFormatId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerPassword> GetByPasswordSalt(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [PasswordSalt] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerPassword> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerPassword where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
