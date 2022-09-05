using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICostumersRepository : IGenericRepo<Costumers>
    {
        List<Costumers> GetById(int value);

        List<Costumers> GetByFirstName(string value);

        List<Costumers> GetByLastName(string value);

        List<Costumers> GetByRegDate(DateTimeOffset value);

    }
}
