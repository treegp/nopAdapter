using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShipmentItemRepository : GenericRepo<ShipmentItem> , IShipmentItemRepository
    {
        string conStr;
        public ShipmentItemRepository(string connection) : base(connection) { conStr = connection; }

        public List<ShipmentItem> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShipmentItem where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShipmentItem> GetByShipmentId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShipmentItem where [ShipmentId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShipmentItem> GetByOrderItemId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShipmentItem where [OrderItemId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShipmentItem> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShipmentItem where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ShipmentItem> GetByWarehouseId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ShipmentItem where [WarehouseId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
