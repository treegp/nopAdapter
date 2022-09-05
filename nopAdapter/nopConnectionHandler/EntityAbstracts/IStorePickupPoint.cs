using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IStorePickupPointRepository : IGenericRepo<StorePickupPoint>
    {
        List<StorePickupPoint> GetById(int value);

        List<StorePickupPoint> GetByName(string value);

        List<StorePickupPoint> GetByDescription(string value);

        List<StorePickupPoint> GetByAddressId(int value);

        List<StorePickupPoint> GetByPickupFee(decimal value);

        List<StorePickupPoint> GetByOpeningHours(string value);

        List<StorePickupPoint> GetByDisplayOrder(int value);

        List<StorePickupPoint> GetByStoreId(int value);

        List<StorePickupPoint> GetByLatitude(Nullable<decimal> value);

        List<StorePickupPoint> GetByLongitude(Nullable<decimal> value);

        List<StorePickupPoint> GetByTransitDays(Nullable<int> value);

    }
}
