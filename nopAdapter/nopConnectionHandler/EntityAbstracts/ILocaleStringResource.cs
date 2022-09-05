using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ILocaleStringResourceRepository : IGenericRepo<LocaleStringResource>
    {
        List<LocaleStringResource> GetById(int value);

        List<LocaleStringResource> GetByResourceName(string value);

        List<LocaleStringResource> GetByResourceValue(string value);

        List<LocaleStringResource> GetByLanguageId(int value);

    }
}
