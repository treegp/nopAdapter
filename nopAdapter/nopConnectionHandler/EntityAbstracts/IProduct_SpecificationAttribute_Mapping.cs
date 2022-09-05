using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_SpecificationAttribute_MappingRepository : IGenericRepo<Product_SpecificationAttribute_Mapping>
    {
        List<Product_SpecificationAttribute_Mapping> GetById(int value);

        List<Product_SpecificationAttribute_Mapping> GetByCustomValue(string value);

        List<Product_SpecificationAttribute_Mapping> GetByProductId(int value);

        List<Product_SpecificationAttribute_Mapping> GetBySpecificationAttributeOptionId(int value);

        List<Product_SpecificationAttribute_Mapping> GetByAttributeTypeId(int value);

        List<Product_SpecificationAttribute_Mapping> GetByAllowFiltering(bool value);

        List<Product_SpecificationAttribute_Mapping> GetByShowOnProductPage(bool value);

        List<Product_SpecificationAttribute_Mapping> GetByDisplayOrder(int value);

    }
}
