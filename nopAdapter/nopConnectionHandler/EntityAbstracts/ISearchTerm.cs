using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISearchTermRepository : IGenericRepo<SearchTerm>
    {
        List<SearchTerm> GetById(int value);

        List<SearchTerm> GetByKeyword(string value);

        List<SearchTerm> GetByStoreId(int value);

        List<SearchTerm> GetByCount(int value);

    }
}
