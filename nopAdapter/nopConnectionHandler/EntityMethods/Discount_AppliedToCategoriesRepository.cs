using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Discount_AppliedToCategoriesRepository : GenericRepo<Discount_AppliedToCategories> , IDiscount_AppliedToCategoriesRepository
    {
        string conStr;
        public Discount_AppliedToCategoriesRepository(string connection) : base(connection) { conStr = connection; }

        public List<Discount_AppliedToCategories> GetByDiscount_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToCategories where [Discount_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount_AppliedToCategories> GetByCategory_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToCategories where [Category_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
