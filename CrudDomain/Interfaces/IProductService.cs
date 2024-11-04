using CrudDomain.Dto;

namespace CrudDomain.Interfaces
{
    public interface IProductService
    {
        Task<ResponseModelDto> GetAllProductsAsync();
        Task<ResponseModelDto> GetProductByIdAsync(int id);
        Task<ResponseModelDto> AddProductAsync(ProductDto productDto);
        Task<ResponseModelDto> UpdateProductAsync(ProductDto productDto);
        Task<ResponseModelDto> DeleteProductAsync(int id);
    }
}
