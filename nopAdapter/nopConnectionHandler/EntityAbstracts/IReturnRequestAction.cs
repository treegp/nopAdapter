using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IReturnRequestActionRepository : IGenericRepo<ReturnRequestAction>
    {
        List<ReturnRequestAction> GetById(int value);

        List<ReturnRequestAction> GetByName(string value);

        List<ReturnRequestAction> GetByDisplayOrder(int value);

    }
}
