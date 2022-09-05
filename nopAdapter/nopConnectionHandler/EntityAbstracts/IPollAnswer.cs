using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPollAnswerRepository : IGenericRepo<PollAnswer>
    {
        List<PollAnswer> GetById(int value);

        List<PollAnswer> GetByName(string value);

        List<PollAnswer> GetByPollId(int value);

        List<PollAnswer> GetByNumberOfVotes(int value);

        List<PollAnswer> GetByDisplayOrder(int value);

    }
}
