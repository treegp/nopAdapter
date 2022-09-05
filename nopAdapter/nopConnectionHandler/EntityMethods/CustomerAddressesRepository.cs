using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CustomerAddressesRepository : GenericRepo<CustomerAddresses> , ICustomerAddressesRepository
    {
        string conStr;
        public CustomerAddressesRepository(string connection) : base(connection) { conStr = connection; }

        public List<CustomerAddresses> GetByAddress_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAddresses where [Address_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CustomerAddresses> GetByCustomer_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CustomerAddresses where [Customer_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
