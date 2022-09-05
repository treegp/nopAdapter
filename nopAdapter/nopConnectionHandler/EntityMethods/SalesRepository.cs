using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SalesRepository : GenericRepo<Sales> , ISalesRepository
    {
        string conStr;
        public SalesRepository(string connection) : base(connection) { conStr = connection; }

        public List<Sales> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Sales> GetByCostumerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [CostumerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Sales> GetByCreatedDate(DateTimeOffset value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [CreatedDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Sales> GetByTotalCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [TotalCost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Sales> GetByAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [AddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Sales> GetByStatus(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Sales where [Status] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
