using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductAttributeCombinationRepository : IGenericRepo<ProductAttributeCombination>
    {
        List<ProductAttributeCombination> GetById(int value);

        List<ProductAttributeCombination> GetBySku(string value);

        List<ProductAttributeCombination> GetByManufacturerPartNumber(string value);

        List<ProductAttributeCombination> GetByGtin(string value);

        List<ProductAttributeCombination> GetByProductId(int value);

        List<ProductAttributeCombination> GetByAttributesXml(string value);

        List<ProductAttributeCombination> GetByStockQuantity(int value);

        List<ProductAttributeCombination> GetByAllowOutOfStockOrders(bool value);

        List<ProductAttributeCombination> GetByOverriddenPrice(Nullable<decimal> value);

        List<ProductAttributeCombination> GetByNotifyAdminForQuantityBelow(int value);

        List<ProductAttributeCombination> GetByPictureId(int value);

        List<ProductAttributeCombination> GetByMinStockQuantity(int value);

    }
}
