using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class StockQuantityHistoryRepository : GenericRepo<StockQuantityHistory> , IStockQuantityHistoryRepository
    {
        string conStr;
        public StockQuantityHistoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<StockQuantityHistory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByQuantityAdjustment(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [QuantityAdjustment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [StockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [Message] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByCombinationId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [CombinationId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StockQuantityHistory> GetByWarehouseId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StockQuantityHistory where [WarehouseId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
