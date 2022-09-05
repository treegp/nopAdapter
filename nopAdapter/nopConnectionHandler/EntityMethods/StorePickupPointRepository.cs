using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class StorePickupPointRepository : GenericRepo<StorePickupPoint> , IStorePickupPointRepository
    {
        string conStr;
        public StorePickupPointRepository(string connection) : base(connection) { conStr = connection; }

        public List<StorePickupPoint> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [AddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByPickupFee(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [PickupFee] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByOpeningHours(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [OpeningHours] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByLatitude(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [Latitude] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByLongitude(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [Longitude] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StorePickupPoint> GetByTransitDays(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StorePickupPoint where [TransitDays] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
