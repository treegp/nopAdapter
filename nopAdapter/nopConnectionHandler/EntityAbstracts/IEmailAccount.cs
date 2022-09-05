using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IEmailAccountRepository : IGenericRepo<EmailAccount>
    {
        List<EmailAccount> GetById(int value);

        List<EmailAccount> GetByDisplayName(string value);

        List<EmailAccount> GetByEmail(string value);

        List<EmailAccount> GetByHost(string value);

        List<EmailAccount> GetByUsername(string value);

        List<EmailAccount> GetByPassword(string value);

        List<EmailAccount> GetByPort(int value);

        List<EmailAccount> GetByEnableSsl(bool value);

        List<EmailAccount> GetByUseDefaultCredentials(bool value);

    }
}
