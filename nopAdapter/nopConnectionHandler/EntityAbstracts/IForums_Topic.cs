using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_TopicRepository : IGenericRepo<Forums_Topic>
    {
        List<Forums_Topic> GetById(int value);

        List<Forums_Topic> GetBySubject(string value);

        List<Forums_Topic> GetByCustomerId(int value);

        List<Forums_Topic> GetByForumId(int value);

        List<Forums_Topic> GetByTopicTypeId(int value);

        List<Forums_Topic> GetByNumPosts(int value);

        List<Forums_Topic> GetByViews(int value);

        List<Forums_Topic> GetByLastPostId(int value);

        List<Forums_Topic> GetByLastPostCustomerId(int value);

        List<Forums_Topic> GetByLastPostTime(Nullable<DateTime> value);

        List<Forums_Topic> GetByCreatedOnUtc(DateTime value);

        List<Forums_Topic> GetByUpdatedOnUtc(DateTime value);

    }
}
