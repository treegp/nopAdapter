using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductWarehouseInventoryRepository : IGenericRepo<ProductWarehouseInventory>
    {
        List<ProductWarehouseInventory> GetById(int value);

        List<ProductWarehouseInventory> GetByProductId(int value);

        List<ProductWarehouseInventory> GetByWarehouseId(int value);

        List<ProductWarehouseInventory> GetByStockQuantity(int value);

        List<ProductWarehouseInventory> GetByReservedQuantity(int value);

    }
}
