using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGdprConsentRepository : IGenericRepo<GdprConsent>
    {
        List<GdprConsent> GetById(int value);

        List<GdprConsent> GetByMessage(string value);

        List<GdprConsent> GetByIsRequired(bool value);

        List<GdprConsent> GetByRequiredMessage(string value);

        List<GdprConsent> GetByDisplayDuringRegistration(bool value);

        List<GdprConsent> GetByDisplayOnCustomerInfoPage(bool value);

        List<GdprConsent> GetByDisplayOrder(int value);

    }
}
