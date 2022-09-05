using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Customer_CustomerRole_MappingRepository : GenericRepo<Customer_CustomerRole_Mapping> , ICustomer_CustomerRole_MappingRepository
    {
        string conStr;
        public Customer_CustomerRole_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<Customer_CustomerRole_Mapping> GetByCustomer_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer_CustomerRole_Mapping where [Customer_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Customer_CustomerRole_Mapping> GetByCustomerRole_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Customer_CustomerRole_Mapping where [CustomerRole_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
