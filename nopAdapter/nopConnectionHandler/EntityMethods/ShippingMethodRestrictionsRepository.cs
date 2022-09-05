using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShippingMethodRestrictionsRepository : GenericRepo<ShippingMethodRestrictions> , IShippingMethodRestrictionsRepository
    {
        string conStr;
        public ShippingMethodRestrictionsRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShippingMethodRestrictions> GetByShippingMethod_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethodRestrictions where [ShippingMethod_Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingMethodRestrictions> GetByCountry_Id(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethodRestrictions where [Country_Id] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
