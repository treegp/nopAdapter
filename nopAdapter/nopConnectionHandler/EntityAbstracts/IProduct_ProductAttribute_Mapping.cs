using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_ProductAttribute_MappingRepository : IGenericRepo<Product_ProductAttribute_Mapping>
    {
        List<Product_ProductAttribute_Mapping> GetById(int value);

        List<Product_ProductAttribute_Mapping> GetByProductAttributeId(int value);

        List<Product_ProductAttribute_Mapping> GetByProductId(int value);

        List<Product_ProductAttribute_Mapping> GetByTextPrompt(string value);

        List<Product_ProductAttribute_Mapping> GetByIsRequired(bool value);

        List<Product_ProductAttribute_Mapping> GetByAttributeControlTypeId(int value);

        List<Product_ProductAttribute_Mapping> GetByDisplayOrder(int value);

        List<Product_ProductAttribute_Mapping> GetByValidationMinLength(Nullable<int> value);

        List<Product_ProductAttribute_Mapping> GetByValidationMaxLength(Nullable<int> value);

        List<Product_ProductAttribute_Mapping> GetByValidationFileAllowedExtensions(string value);

        List<Product_ProductAttribute_Mapping> GetByValidationFileMaximumSize(Nullable<int> value);

        List<Product_ProductAttribute_Mapping> GetByDefaultValue(string value);

        List<Product_ProductAttribute_Mapping> GetByConditionAttributeXml(string value);

    }
}
