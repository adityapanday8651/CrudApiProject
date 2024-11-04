using CrudDomain.Dto;
using CrudDomain.Interfaces;
using CrudDomain.Models;

namespace CrudInfrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IBaseRepository<Product> _repository;
        public Task<ResponseModelDto> AddProductAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
        public ProductRepository(IBaseRepository<Product> repository)
        {
            _repository = repository;
        }
        public Task<ResponseModelDto> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModelDto> GetAllProductsAsync()
        {
            var lstProduct = await _repository.GetAllAsync();
            List<ProductDto> lstProductDto = lstProduct.Select(x => new ProductDto
            {
                Name = x.Name,
                Id = x.Id,
                CategoryId = x.CategoryId,
                Price = x.Price
            }).ToList();
            return ResponseModelDto.CreateResponseData(true, "Retrieve all Product", lstProductDto);
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
