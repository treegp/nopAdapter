using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ShippingByWeightByTotalRecord
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal WeightFrom { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal WeightTo { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubtotalFrom { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal OrderSubtotalTo { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal AdditionalFixedCost { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PercentageRateOfSubtotal { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal RatePerWeightUnit { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal LowerWeightLimit { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Zip { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int WarehouseId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CountryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StateProvinceId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ShippingMethodId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> TransitDays { get; set; }

    }
}
