using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Country
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string TwoLetterIsoCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ThreeLetterIsoCode { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowsBilling { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowsShipping { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int NumericIsoCode { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool SubjectToVat { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

    }
}
