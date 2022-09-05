using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IMeasureWeightRepository : IGenericRepo<MeasureWeight>
    {
        List<MeasureWeight> GetById(int value);

        List<MeasureWeight> GetByName(string value);

        List<MeasureWeight> GetBySystemKeyword(string value);

        List<MeasureWeight> GetByRatio(decimal value);

        List<MeasureWeight> GetByDisplayOrder(int value);

    }
}
