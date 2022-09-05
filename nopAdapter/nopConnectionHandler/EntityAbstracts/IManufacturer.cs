using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IManufacturerRepository : IGenericRepo<Manufacturer>
    {
        List<Manufacturer> GetById(int value);

        List<Manufacturer> GetByName(string value);

        List<Manufacturer> GetByMetaKeywords(string value);

        List<Manufacturer> GetByMetaTitle(string value);

        List<Manufacturer> GetByPageSizeOptions(string value);

        List<Manufacturer> GetByDescription(string value);

        List<Manufacturer> GetByManufacturerTemplateId(int value);

        List<Manufacturer> GetByMetaDescription(string value);

        List<Manufacturer> GetByPictureId(int value);

        List<Manufacturer> GetByPageSize(int value);

        List<Manufacturer> GetByAllowCustomersToSelectPageSize(bool value);

        List<Manufacturer> GetBySubjectToAcl(bool value);

        List<Manufacturer> GetByLimitedToStores(bool value);

        List<Manufacturer> GetByPublished(bool value);

        List<Manufacturer> GetByDeleted(bool value);

        List<Manufacturer> GetByDisplayOrder(int value);

        List<Manufacturer> GetByCreatedOnUtc(DateTime value);

        List<Manufacturer> GetByUpdatedOnUtc(DateTime value);

        List<Manufacturer> GetByPriceRangeFiltering(bool value);

        List<Manufacturer> GetByPriceFrom(decimal value);

        List<Manufacturer> GetByPriceTo(decimal value);

        List<Manufacturer> GetByManuallyPriceRange(bool value);

    }
}
