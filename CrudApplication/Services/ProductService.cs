using CrudDomain.Dto;
using CrudDomain.Interfaces;
using CrudDomain.Models;

namespace CrudApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<ResponseModelDto> AddProductAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModelDto> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModelDto> GetAllProductsAsync()
        {
           return await _productRepository.GetAllProductsAsync();
        }

        public Task<ResponseModelDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModelDto> UpdateProductAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
