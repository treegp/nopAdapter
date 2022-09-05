using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDownloadRepository : IGenericRepo<Download>
    {
        List<Download> GetById(int value);

        List<Download> GetByDownloadGuid(Guid value);

        List<Download> GetByUseDownloadUrl(bool value);

        List<Download> GetByDownloadUrl(string value);

        List<Download> GetByDownloadBinary(byte[] value);

        List<Download> GetByContentType(string value);

        List<Download> GetByFilename(string value);

        List<Download> GetByExtension(string value);

        List<Download> GetByIsNew(bool value);

    }
}
