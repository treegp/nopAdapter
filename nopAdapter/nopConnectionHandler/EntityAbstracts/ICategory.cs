using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICategoryRepository : IGenericRepo<Category>
    {
        List<Category> GetById(int value);

        List<Category> GetByName(string value);

        List<Category> GetByMetaKeywords(string value);

        List<Category> GetByMetaTitle(string value);

        List<Category> GetByPageSizeOptions(string value);

        List<Category> GetByDescription(string value);

        List<Category> GetByCategoryTemplateId(int value);

        List<Category> GetByMetaDescription(string value);

        List<Category> GetByParentCategoryId(int value);

        List<Category> GetByPictureId(int value);

        List<Category> GetByPageSize(int value);

        List<Category> GetByAllowCustomersToSelectPageSize(bool value);

        List<Category> GetByShowOnHomepage(bool value);

        List<Category> GetByIncludeInTopMenu(bool value);

        List<Category> GetBySubjectToAcl(bool value);

        List<Category> GetByLimitedToStores(bool value);

        List<Category> GetByPublished(bool value);

        List<Category> GetByDeleted(bool value);

        List<Category> GetByDisplayOrder(int value);

        List<Category> GetByCreatedOnUtc(DateTime value);

        List<Category> GetByUpdatedOnUtc(DateTime value);

        List<Category> GetByPriceRangeFiltering(bool value);

        List<Category> GetByPriceFrom(decimal value);

        List<Category> GetByPriceTo(decimal value);

        List<Category> GetByManuallyPriceRange(bool value);

    }
}
