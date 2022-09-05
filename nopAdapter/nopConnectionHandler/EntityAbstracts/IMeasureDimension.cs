using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IMeasureDimensionRepository : IGenericRepo<MeasureDimension>
    {
        List<MeasureDimension> GetById(int value);

        List<MeasureDimension> GetByName(string value);

        List<MeasureDimension> GetBySystemKeyword(string value);

        List<MeasureDimension> GetByRatio(decimal value);

        List<MeasureDimension> GetByDisplayOrder(int value);

    }
}
