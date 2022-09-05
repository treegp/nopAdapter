using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IStockQuantityHistoryRepository : IGenericRepo<StockQuantityHistory>
    {
        List<StockQuantityHistory> GetById(int value);

        List<StockQuantityHistory> GetByProductId(int value);

        List<StockQuantityHistory> GetByQuantityAdjustment(int value);

        List<StockQuantityHistory> GetByStockQuantity(int value);

        List<StockQuantityHistory> GetByMessage(string value);

        List<StockQuantityHistory> GetByCreatedOnUtc(DateTime value);

        List<StockQuantityHistory> GetByCombinationId(Nullable<int> value);

        List<StockQuantityHistory> GetByWarehouseId(Nullable<int> value);

    }
}
