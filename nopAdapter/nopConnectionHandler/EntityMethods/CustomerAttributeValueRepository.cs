using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerAttributeValueRepository : GenericRepo<CustomerAttributeValue> , ICustomerAttributeValueRepository
    {
        string conStr;
        public CustomerAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<CustomerAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttributeValue> GetByCustomerAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttributeValue where [CustomerAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
