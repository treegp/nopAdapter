using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IRelatedProductRepository : IGenericRepo<RelatedProduct>
    {
        List<RelatedProduct> GetById(int value);

        List<RelatedProduct> GetByProductId1(int value);

        List<RelatedProduct> GetByProductId2(int value);

        List<RelatedProduct> GetByDisplayOrder(int value);

    }
}
