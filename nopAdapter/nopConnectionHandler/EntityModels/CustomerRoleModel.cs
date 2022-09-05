using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CustomerRole
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SystemName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool FreeShipping { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool TaxExempt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Active { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsSystemRole { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool EnablePasswordLifetime { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool OverrideTaxDisplayType { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DefaultTaxDisplayTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PurchasedWithProductId { get; set; }

    }
}
