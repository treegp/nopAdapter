using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IPictureBinaryRepository : IGenericRepo<PictureBinary>
    {
        List<PictureBinary> GetById(int value);

        List<PictureBinary> GetByPictureId(int value);

        List<PictureBinary> GetByBinaryData(byte[] value);

    }
}
