using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_GroupRepository : IGenericRepo<Forums_Group>
    {
        List<Forums_Group> GetById(int value);

        List<Forums_Group> GetByName(string value);

        List<Forums_Group> GetByDisplayOrder(int value);

        List<Forums_Group> GetByCreatedOnUtc(DateTime value);

        List<Forums_Group> GetByUpdatedOnUtc(DateTime value);

    }
}
