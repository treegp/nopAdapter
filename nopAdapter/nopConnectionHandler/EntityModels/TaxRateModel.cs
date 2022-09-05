using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class TaxRate
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TaxCategoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CountryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StateProvinceId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Zip { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Percentage { get; set; }

    }
}
