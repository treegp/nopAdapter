using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PollVotingRecordRepository : GenericRepo<PollVotingRecord> , IPollVotingRecordRepository
    {
        string conStr;
        public PollVotingRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<PollVotingRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollVotingRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollVotingRecord> GetByPollAnswerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollVotingRecord where [PollAnswerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollVotingRecord> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollVotingRecord where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PollVotingRecord> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PollVotingRecord where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
