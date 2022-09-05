using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface INewsRepository : IGenericRepo<News>
    {
        List<News> GetById(int value);

        List<News> GetByTitle(string value);

        List<News> GetByShort(string value);

        List<News> GetByFull(string value);

        List<News> GetByMetaKeywords(string value);

        List<News> GetByMetaTitle(string value);

        List<News> GetByLanguageId(int value);

        List<News> GetByPublished(bool value);

        List<News> GetByStartDateUtc(Nullable<DateTime> value);

        List<News> GetByEndDateUtc(Nullable<DateTime> value);

        List<News> GetByAllowComments(bool value);

        List<News> GetByLimitedToStores(bool value);

        List<News> GetByMetaDescription(string value);

        List<News> GetByCreatedOnUtc(DateTime value);

    }
}
