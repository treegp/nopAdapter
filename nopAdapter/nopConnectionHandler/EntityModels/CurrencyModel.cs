using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Currency
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string CurrencyCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string DisplayLocale { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomFormatting { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Rate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int RoundingTypeId { get; set; }

    }
}
