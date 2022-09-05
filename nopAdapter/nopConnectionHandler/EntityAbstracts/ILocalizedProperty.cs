using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ILocalizedPropertyRepository : IGenericRepo<LocalizedProperty>
    {
        List<LocalizedProperty> GetById(int value);

        List<LocalizedProperty> GetByLocaleKeyGroup(string value);

        List<LocalizedProperty> GetByLocaleKey(string value);

        List<LocalizedProperty> GetByLocaleValue(string value);

        List<LocalizedProperty> GetByLanguageId(int value);

        List<LocalizedProperty> GetByEntityId(int value);

    }
}
