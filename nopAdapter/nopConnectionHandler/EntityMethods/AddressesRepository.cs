using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AddressesRepository : GenericRepo<Addresses> , IAddressesRepository
    {
        string conStr;
        public AddressesRepository(string connection) : base(connection) { conStr = connection; }

        public List<Addresses> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Addresses where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Addresses> GetByAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Addresses where [Address] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Addresses> GetByTel(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Addresses where [Tel] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Addresses> GetByCostumerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Addresses where [CostumerId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
