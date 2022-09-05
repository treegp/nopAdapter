using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_ForumRepository : IGenericRepo<Forums_Forum>
    {
        List<Forums_Forum> GetById(int value);

        List<Forums_Forum> GetByName(string value);

        List<Forums_Forum> GetByForumGroupId(int value);

        List<Forums_Forum> GetByDescription(string value);

        List<Forums_Forum> GetByNumTopics(int value);

        List<Forums_Forum> GetByNumPosts(int value);

        List<Forums_Forum> GetByLastTopicId(int value);

        List<Forums_Forum> GetByLastPostId(int value);

        List<Forums_Forum> GetByLastPostCustomerId(int value);

        List<Forums_Forum> GetByLastPostTime(Nullable<DateTime> value);

        List<Forums_Forum> GetByDisplayOrder(int value);

        List<Forums_Forum> GetByCreatedOnUtc(DateTime value);

        List<Forums_Forum> GetByUpdatedOnUtc(DateTime value);

    }
}
