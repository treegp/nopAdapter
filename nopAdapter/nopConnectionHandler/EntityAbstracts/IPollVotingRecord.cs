using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPollVotingRecordRepository : IGenericRepo<PollVotingRecord>
    {
        List<PollVotingRecord> GetById(int value);

        List<PollVotingRecord> GetByPollAnswerId(int value);

        List<PollVotingRecord> GetByCustomerId(int value);

        List<PollVotingRecord> GetByCreatedOnUtc(DateTime value);

    }
}
