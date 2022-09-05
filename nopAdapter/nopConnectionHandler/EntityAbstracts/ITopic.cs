using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ITopicRepository : IGenericRepo<Topic>
    {
        List<Topic> GetById(int value);

        List<Topic> GetBySystemName(string value);

        List<Topic> GetByIncludeInSitemap(bool value);

        List<Topic> GetByIncludeInTopMenu(bool value);

        List<Topic> GetByIncludeInFooterColumn1(bool value);

        List<Topic> GetByIncludeInFooterColumn2(bool value);

        List<Topic> GetByIncludeInFooterColumn3(bool value);

        List<Topic> GetByDisplayOrder(int value);

        List<Topic> GetByAccessibleWhenStoreClosed(bool value);

        List<Topic> GetByIsPasswordProtected(bool value);

        List<Topic> GetByPassword(string value);

        List<Topic> GetByTitle(string value);

        List<Topic> GetByBody(string value);

        List<Topic> GetByPublished(bool value);

        List<Topic> GetByTopicTemplateId(int value);

        List<Topic> GetByMetaKeywords(string value);

        List<Topic> GetByMetaDescription(string value);

        List<Topic> GetByMetaTitle(string value);

        List<Topic> GetBySubjectToAcl(bool value);

        List<Topic> GetByLimitedToStores(bool value);

    }
}
