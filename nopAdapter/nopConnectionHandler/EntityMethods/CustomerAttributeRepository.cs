using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerAttributeRepository : GenericRepo<CustomerAttribute> , ICustomerAttributeRepository
    {
        string conStr;
        public CustomerAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<CustomerAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttribute> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttribute where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttribute> GetByAttributeControlTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttribute where [AttributeControlTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttribute> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttribute where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
