using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPollRepository : IGenericRepo<Poll>
    {
        List<Poll> GetById(int value);

        List<Poll> GetByName(string value);

        List<Poll> GetByLanguageId(int value);

        List<Poll> GetBySystemKeyword(string value);

        List<Poll> GetByPublished(bool value);

        List<Poll> GetByShowOnHomepage(bool value);

        List<Poll> GetByAllowGuestsToVote(bool value);

        List<Poll> GetByDisplayOrder(int value);

        List<Poll> GetByLimitedToStores(bool value);

        List<Poll> GetByStartDateUtc(Nullable<DateTime> value);

        List<Poll> GetByEndDateUtc(Nullable<DateTime> value);

    }
}
