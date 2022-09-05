using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IReturnRequestReasonRepository : IGenericRepo<ReturnRequestReason>
    {
        List<ReturnRequestReason> GetById(int value);

        List<ReturnRequestReason> GetByName(string value);

        List<ReturnRequestReason> GetByDisplayOrder(int value);

    }
}
