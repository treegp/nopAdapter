using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class News
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Short { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Full { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaKeywords { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaTitle { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LanguageId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> StartDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> EndDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowComments { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaDescription { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
