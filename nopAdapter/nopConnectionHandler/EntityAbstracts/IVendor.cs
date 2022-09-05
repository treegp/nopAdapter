using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IVendorRepository : IGenericRepo<Vendor>
    {
        List<Vendor> GetById(int value);

        List<Vendor> GetByName(string value);

        List<Vendor> GetByEmail(string value);

        List<Vendor> GetByMetaKeywords(string value);

        List<Vendor> GetByMetaTitle(string value);

        List<Vendor> GetByPageSizeOptions(string value);

        List<Vendor> GetByDescription(string value);

        List<Vendor> GetByPictureId(int value);

        List<Vendor> GetByAddressId(int value);

        List<Vendor> GetByAdminComment(string value);

        List<Vendor> GetByActive(bool value);

        List<Vendor> GetByDeleted(bool value);

        List<Vendor> GetByDisplayOrder(int value);

        List<Vendor> GetByMetaDescription(string value);

        List<Vendor> GetByPageSize(int value);

        List<Vendor> GetByAllowCustomersToSelectPageSize(bool value);

        List<Vendor> GetByPriceRangeFiltering(bool value);

        List<Vendor> GetByPriceFrom(decimal value);

        List<Vendor> GetByPriceTo(decimal value);

        List<Vendor> GetByManuallyPriceRange(bool value);

    }
}
