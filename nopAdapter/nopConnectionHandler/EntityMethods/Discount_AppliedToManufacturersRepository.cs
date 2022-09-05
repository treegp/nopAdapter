using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Discount_AppliedToManufacturersRepository : GenericRepo<Discount_AppliedToManufacturers> , IDiscount_AppliedToManufacturersRepository
    {
        string conStr;
        public Discount_AppliedToManufacturersRepository(string connection) : base(connection) { conStr = connection; }

        public List<Discount_AppliedToManufacturers> GetByDiscount_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToManufacturers where [Discount_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount_AppliedToManufacturers> GetByManufacturer_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount_AppliedToManufacturers where [Manufacturer_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
