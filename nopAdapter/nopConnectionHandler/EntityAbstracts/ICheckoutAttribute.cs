using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICheckoutAttributeRepository : IGenericRepo<CheckoutAttribute>
    {
        List<CheckoutAttribute> GetById(int value);

        List<CheckoutAttribute> GetByName(string value);

        List<CheckoutAttribute> GetByTextPrompt(string value);

        List<CheckoutAttribute> GetByIsRequired(bool value);

        List<CheckoutAttribute> GetByShippableProductRequired(bool value);

        List<CheckoutAttribute> GetByIsTaxExempt(bool value);

        List<CheckoutAttribute> GetByTaxCategoryId(int value);

        List<CheckoutAttribute> GetByAttributeControlTypeId(int value);

        List<CheckoutAttribute> GetByDisplayOrder(int value);

        List<CheckoutAttribute> GetByLimitedToStores(bool value);

        List<CheckoutAttribute> GetByValidationMinLength(Nullable<int> value);

        List<CheckoutAttribute> GetByValidationMaxLength(Nullable<int> value);

        List<CheckoutAttribute> GetByValidationFileAllowedExtensions(string value);

        List<CheckoutAttribute> GetByValidationFileMaximumSize(Nullable<int> value);

        List<CheckoutAttribute> GetByDefaultValue(string value);

        List<CheckoutAttribute> GetByConditionAttributeXml(string value);

    }
}
