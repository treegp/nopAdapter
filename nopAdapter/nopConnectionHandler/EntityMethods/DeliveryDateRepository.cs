using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class DeliveryDateRepository : GenericRepo<DeliveryDate> , IDeliveryDateRepository
    {
        string conStr;
        public DeliveryDateRepository(string connection) : base(connection) { conStr = connection; }

        public List<DeliveryDate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DeliveryDate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DeliveryDate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DeliveryDate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DeliveryDate> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DeliveryDate where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
