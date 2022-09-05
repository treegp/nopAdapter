using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPictureRepository : IGenericRepo<Picture>
    {
        List<Picture> GetById(int value);

        List<Picture> GetByMimeType(string value);

        List<Picture> GetBySeoFilename(string value);

        List<Picture> GetByAltAttribute(string value);

        List<Picture> GetByTitleAttribute(string value);

        List<Picture> GetByIsNew(bool value);

        List<Picture> GetByVirtualPath(string value);

    }
}
