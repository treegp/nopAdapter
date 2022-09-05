using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Discount_AppliedToProductsRepository : GenericRepo<Discount_AppliedToProducts> , IDiscount_AppliedToProductsRepository
    {
        string conStr;
        public Discount_AppliedToProductsRepository(string connection) : base(connection) { conStr = connection; }

        public List<Discount_AppliedToProducts> GetByDiscount_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToProducts where [Discount_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount_AppliedToProducts> GetByProduct_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToProducts where [Product_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
