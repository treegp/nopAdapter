using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IShipmentItemRepository : IGenericRepo<ShipmentItem>
    {
        List<ShipmentItem> GetById(int value);

        List<ShipmentItem> GetByShipmentId(int value);

        List<ShipmentItem> GetByOrderItemId(int value);

        List<ShipmentItem> GetByQuantity(int value);

        List<ShipmentItem> GetByWarehouseId(int value);

    }
}
