using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IVendorNoteRepository : IGenericRepo<VendorNote>
    {
        List<VendorNote> GetById(int value);

        List<VendorNote> GetByNote(string value);

        List<VendorNote> GetByVendorId(int value);

        List<VendorNote> GetByCreatedOnUtc(DateTime value);

    }
}
