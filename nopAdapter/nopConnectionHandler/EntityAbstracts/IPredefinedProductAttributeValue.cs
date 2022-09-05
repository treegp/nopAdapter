using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPredefinedProductAttributeValueRepository : IGenericRepo<PredefinedProductAttributeValue>
    {
        List<PredefinedProductAttributeValue> GetById(int value);

        List<PredefinedProductAttributeValue> GetByName(string value);

        List<PredefinedProductAttributeValue> GetByProductAttributeId(int value);

        List<PredefinedProductAttributeValue> GetByPriceAdjustment(decimal value);

        List<PredefinedProductAttributeValue> GetByPriceAdjustmentUsePercentage(bool value);

        List<PredefinedProductAttributeValue> GetByWeightAdjustment(decimal value);

        List<PredefinedProductAttributeValue> GetByCost(decimal value);

        List<PredefinedProductAttributeValue> GetByIsPreSelected(bool value);

        List<PredefinedProductAttributeValue> GetByDisplayOrder(int value);

    }
}
