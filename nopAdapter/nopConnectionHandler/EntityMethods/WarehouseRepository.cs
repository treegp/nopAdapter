using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class WarehouseRepository : GenericRepo<Warehouse> , IWarehouseRepository
    {
        string conStr;
        public WarehouseRepository(string connection) : base(connection) { conStr = connection; }

        public List<Warehouse> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Warehouse where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Warehouse> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Warehouse where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Warehouse> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Warehouse where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Warehouse> GetByAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Warehouse where [AddressId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
