using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_PostRepository : IGenericRepo<Forums_Post>
    {
        List<Forums_Post> GetById(int value);

        List<Forums_Post> GetByText(string value);

        List<Forums_Post> GetByIPAddress(string value);

        List<Forums_Post> GetByCustomerId(int value);

        List<Forums_Post> GetByTopicId(int value);

        List<Forums_Post> GetByCreatedOnUtc(DateTime value);

        List<Forums_Post> GetByUpdatedOnUtc(DateTime value);

        List<Forums_Post> GetByVoteCount(int value);

    }
}
