using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Topic
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SystemName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IncludeInSitemap { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IncludeInTopMenu { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IncludeInFooterColumn1 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IncludeInFooterColumn2 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IncludeInFooterColumn3 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AccessibleWhenStoreClosed { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsPasswordProtected { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Password { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Body { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TopicTemplateId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaKeywords { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaDescription { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string MetaTitle { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool SubjectToAcl { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

    }
}
