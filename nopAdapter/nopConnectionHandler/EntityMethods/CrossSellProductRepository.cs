using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CrossSellProductRepository : GenericRepo<CrossSellProduct> , ICrossSellProductRepository
    {
        string conStr;
        public CrossSellProductRepository(string connection) : base(connection) { conStr = connection; }

        public List<CrossSellProduct> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CrossSellProduct where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CrossSellProduct> GetByProductId1(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CrossSellProduct where [ProductId1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CrossSellProduct> GetByProductId2(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CrossSellProduct where [ProductId2] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
