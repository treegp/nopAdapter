using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SaleItemsRepository : GenericRepo<SaleItems> , ISaleItemsRepository
    {
        string conStr;
        public SaleItemsRepository(string connection) : base(connection) { conStr = connection; }

        public List<SaleItems> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SaleItems where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SaleItems> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SaleItems where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SaleItems> GetByCost(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SaleItems where [Cost] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SaleItems> GetBySaleId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SaleItems where [SaleId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
