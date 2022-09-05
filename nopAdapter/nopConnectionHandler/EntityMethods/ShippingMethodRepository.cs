using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShippingMethodRepository : GenericRepo<ShippingMethod> , IShippingMethodRepository
    {
        string conStr;
        public ShippingMethodRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShippingMethod> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethod where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingMethod> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethod where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingMethod> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethod where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShippingMethod> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShippingMethod where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
