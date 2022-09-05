using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ILanguageRepository : IGenericRepo<Language>
    {
        List<Language> GetById(int value);

        List<Language> GetByName(string value);

        List<Language> GetByLanguageCulture(string value);

        List<Language> GetByUniqueSeoCode(string value);

        List<Language> GetByFlagImageFileName(string value);

        List<Language> GetByRtl(bool value);

        List<Language> GetByLimitedToStores(bool value);

        List<Language> GetByDefaultCurrencyId(int value);

        List<Language> GetByPublished(bool value);

        List<Language> GetByDisplayOrder(int value);

    }
}
