using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IOrderNoteRepository : IGenericRepo<OrderNote>
    {
        List<OrderNote> GetById(int value);

        List<OrderNote> GetByNote(string value);

        List<OrderNote> GetByOrderId(int value);

        List<OrderNote> GetByDownloadId(int value);

        List<OrderNote> GetByDisplayToCustomer(bool value);

        List<OrderNote> GetByCreatedOnUtc(DateTime value);

    }
}
