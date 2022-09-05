using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IExternalAuthenticationRecordRepository : IGenericRepo<ExternalAuthenticationRecord>
    {
        List<ExternalAuthenticationRecord> GetById(int value);

        List<ExternalAuthenticationRecord> GetByCustomerId(int value);

        List<ExternalAuthenticationRecord> GetByEmail(string value);

        List<ExternalAuthenticationRecord> GetByExternalIdentifier(string value);

        List<ExternalAuthenticationRecord> GetByExternalDisplayIdentifier(string value);

        List<ExternalAuthenticationRecord> GetByOAuthToken(string value);

        List<ExternalAuthenticationRecord> GetByOAuthAccessToken(string value);

        List<ExternalAuthenticationRecord> GetByProviderSystemName(string value);

    }
}
