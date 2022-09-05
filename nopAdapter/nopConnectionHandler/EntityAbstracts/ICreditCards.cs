using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICreditCardsRepository : IGenericRepo<CreditCards>
    {
        List<CreditCards> GetById(int value);

        List<CreditCards> GetByCardNumber(string value);

        List<CreditCards> GetByExpireDate(DateTimeOffset value);

        List<CreditCards> GetByCustomerId(int value);

    }
}
