using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_PostVoteRepository : IGenericRepo<Forums_PostVote>
    {
        List<Forums_PostVote> GetById(int value);

        List<Forums_PostVote> GetByForumPostId(int value);

        List<Forums_PostVote> GetByCustomerId(int value);

        List<Forums_PostVote> GetByIsUp(bool value);

        List<Forums_PostVote> GetByCreatedOnUtc(DateTime value);

    }
}
