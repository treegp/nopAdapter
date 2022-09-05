using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IManufacturerTemplateRepository : IGenericRepo<ManufacturerTemplate>
    {
        List<ManufacturerTemplate> GetById(int value);

        List<ManufacturerTemplate> GetByName(string value);

        List<ManufacturerTemplate> GetByViewPath(string value);

        List<ManufacturerTemplate> GetByDisplayOrder(int value);

    }
}
