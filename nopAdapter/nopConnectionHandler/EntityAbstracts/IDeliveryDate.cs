using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDeliveryDateRepository : IGenericRepo<DeliveryDate>
    {
        List<DeliveryDate> GetById(int value);

        List<DeliveryDate> GetByName(string value);

        List<DeliveryDate> GetByDisplayOrder(int value);

    }
}
