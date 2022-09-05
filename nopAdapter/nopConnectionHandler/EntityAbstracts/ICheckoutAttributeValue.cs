using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICheckoutAttributeValueRepository : IGenericRepo<CheckoutAttributeValue>
    {
        List<CheckoutAttributeValue> GetById(int value);

        List<CheckoutAttributeValue> GetByName(string value);

        List<CheckoutAttributeValue> GetByColorSquaresRgb(string value);

        List<CheckoutAttributeValue> GetByCheckoutAttributeId(int value);

        List<CheckoutAttributeValue> GetByPriceAdjustment(decimal value);

        List<CheckoutAttributeValue> GetByWeightAdjustment(decimal value);

        List<CheckoutAttributeValue> GetByIsPreSelected(bool value);

        List<CheckoutAttributeValue> GetByDisplayOrder(int value);

    }
}
