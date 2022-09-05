using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ShipmentRepository : GenericRepo<Shipment> , IShipmentRepository
    {
        string conStr;
        public ShipmentRepository(string connection) : base(connection) { conStr = connection; }

        public List<Shipment> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [OrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByTrackingNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [TrackingNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByTotalWeight(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [TotalWeight] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByShippedDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [ShippedDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByDeliveryDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [DeliveryDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByReadyForPickupDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [ReadyForPickupDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Shipment> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Shipment where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
