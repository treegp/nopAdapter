using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Manufacturer
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaKeywords { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaTitle { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string PageSizeOptions { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ManufacturerTemplateId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaDescription { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PictureId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PageSize { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool SubjectToAcl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool PriceRangeFiltering { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceFrom { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal PriceTo { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ManuallyPriceRange { get; set; }

    }
}
