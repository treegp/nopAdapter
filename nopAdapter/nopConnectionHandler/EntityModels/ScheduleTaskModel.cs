using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ScheduleTask
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Type { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Seconds { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastEnabledUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Enabled { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool StopOnError { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastStartUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastEndUtc { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> LastSuccessUtc { get; set; }

    }
}
