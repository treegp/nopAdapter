using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICurrencyRepository : IGenericRepo<Currency>
    {
        List<Currency> GetById(int value);

        List<Currency> GetByName(string value);

        List<Currency> GetByCurrencyCode(string value);

        List<Currency> GetByDisplayLocale(string value);

        List<Currency> GetByCustomFormatting(string value);

        List<Currency> GetByRate(decimal value);

        List<Currency> GetByLimitedToStores(bool value);

        List<Currency> GetByPublished(bool value);

        List<Currency> GetByDisplayOrder(int value);

        List<Currency> GetByCreatedOnUtc(DateTime value);

        List<Currency> GetByUpdatedOnUtc(DateTime value);

        List<Currency> GetByRoundingTypeId(int value);

    }
}
