using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IUrlRecordRepository : IGenericRepo<UrlRecord>
    {
        List<UrlRecord> GetById(int value);

        List<UrlRecord> GetByEntityName(string value);

        List<UrlRecord> GetBySlug(string value);

        List<UrlRecord> GetByEntityId(int value);

        List<UrlRecord> GetByIsActive(bool value);

        List<UrlRecord> GetByLanguageId(int value);

    }
}
