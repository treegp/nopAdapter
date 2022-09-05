using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Language
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LanguageCulture { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string UniqueSeoCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FlagImageFileName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Rtl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DefaultCurrencyId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
