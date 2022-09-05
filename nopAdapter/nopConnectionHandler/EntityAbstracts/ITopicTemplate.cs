using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ITopicTemplateRepository : IGenericRepo<TopicTemplate>
    {
        List<TopicTemplate> GetById(int value);

        List<TopicTemplate> GetByName(string value);

        List<TopicTemplate> GetByViewPath(string value);

        List<TopicTemplate> GetByDisplayOrder(int value);

    }
}
