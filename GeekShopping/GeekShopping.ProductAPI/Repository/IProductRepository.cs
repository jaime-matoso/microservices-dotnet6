using GeekShopping.ProductAPI.Data.ValueObject;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAllAsync();

        Task<ProductVO> FindByIdAsync(long id);

        Task<ProductVO> UpdateByIdAsync(ProductVO productVO);

        Task<bool> DeleteByIdAsync(long id);
        
        Task<ProductVO> CreateByIdAsync(ProductVO productVO);

    }
}
