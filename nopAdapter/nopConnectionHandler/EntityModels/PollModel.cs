using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Poll
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LanguageId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SystemKeyword { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Published { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ShowOnHomepage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowGuestsToVote { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> StartDateUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> EndDateUtc { get; set; }

    }
}
