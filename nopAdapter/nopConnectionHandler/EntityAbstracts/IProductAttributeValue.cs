using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductAttributeValueRepository : IGenericRepo<ProductAttributeValue>
    {
        List<ProductAttributeValue> GetById(int value);

        List<ProductAttributeValue> GetByName(string value);

        List<ProductAttributeValue> GetByColorSquaresRgb(string value);

        List<ProductAttributeValue> GetByProductAttributeMappingId(int value);

        List<ProductAttributeValue> GetByAttributeValueTypeId(int value);

        List<ProductAttributeValue> GetByAssociatedProductId(int value);

        List<ProductAttributeValue> GetByImageSquaresPictureId(int value);

        List<ProductAttributeValue> GetByPriceAdjustment(decimal value);

        List<ProductAttributeValue> GetByPriceAdjustmentUsePercentage(bool value);

        List<ProductAttributeValue> GetByWeightAdjustment(decimal value);

        List<ProductAttributeValue> GetByCost(decimal value);

        List<ProductAttributeValue> GetByCustomerEntersQty(bool value);

        List<ProductAttributeValue> GetByQuantity(int value);

        List<ProductAttributeValue> GetByIsPreSelected(bool value);

        List<ProductAttributeValue> GetByDisplayOrder(int value);

        List<ProductAttributeValue> GetByPictureId(int value);

    }
}
