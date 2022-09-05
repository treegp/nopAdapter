using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IBlogPostRepository : IGenericRepo<BlogPost>
    {
        List<BlogPost> GetById(int value);

        List<BlogPost> GetByTitle(string value);

        List<BlogPost> GetByBody(string value);

        List<BlogPost> GetByMetaKeywords(string value);

        List<BlogPost> GetByMetaTitle(string value);

        List<BlogPost> GetByLanguageId(int value);

        List<BlogPost> GetByIncludeInSitemap(bool value);

        List<BlogPost> GetByBodyOverview(string value);

        List<BlogPost> GetByAllowComments(bool value);

        List<BlogPost> GetByTags(string value);

        List<BlogPost> GetByStartDateUtc(Nullable<DateTime> value);

        List<BlogPost> GetByEndDateUtc(Nullable<DateTime> value);

        List<BlogPost> GetByMetaDescription(string value);

        List<BlogPost> GetByLimitedToStores(bool value);

        List<BlogPost> GetByCreatedOnUtc(DateTime value);

    }
}
