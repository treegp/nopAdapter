using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductWarehouseInventoryRepository : GenericRepo<ProductWarehouseInventory> , IProductWarehouseInventoryRepository
    {
        string conStr;
        public ProductWarehouseInventoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductWarehouseInventory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductWarehouseInventory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductWarehouseInventory> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductWarehouseInventory where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductWarehouseInventory> GetByWarehouseId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductWarehouseInventory where [WarehouseId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductWarehouseInventory> GetByStockQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductWarehouseInventory where [StockQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductWarehouseInventory> GetByReservedQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductWarehouseInventory where [ReservedQuantity] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
