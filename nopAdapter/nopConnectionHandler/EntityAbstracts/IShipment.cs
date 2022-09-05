using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShipmentRepository : IGenericRepo<Shipment>
    {
        List<Shipment> GetById(int value);

        List<Shipment> GetByOrderId(int value);

        List<Shipment> GetByTrackingNumber(string value);

        List<Shipment> GetByTotalWeight(Nullable<decimal> value);

        List<Shipment> GetByShippedDateUtc(Nullable<DateTime> value);

        List<Shipment> GetByDeliveryDateUtc(Nullable<DateTime> value);

        List<Shipment> GetByReadyForPickupDateUtc(Nullable<DateTime> value);

        List<Shipment> GetByAdminComment(string value);

        List<Shipment> GetByCreatedOnUtc(DateTime value);

    }
}
