using AutoMapper;
using Core.Models;
using Core.UnitOfWork;
using Shared.SearchDTO;
using System;

namespace Applocation.ProductManager
{
    public class ProductManager : IProductManager
    {
        IUnitOfWork<Product> products;
        IMapper mapper;

        public ProductManager(IUnitOfWork<Product> products, IMapper mapper)
        {
            this.products = products;
            this.mapper = mapper;
        }

        public List<ProductDTO> productSearch(string product)
        {
            if (string.IsNullOrEmpty(product))
            {
                return new List<ProductDTO>();
            }

            return mapper.Map<List<ProductDTO>>(products.FindAll(x => x.Description.Contains(product), 20));
            //return mapper.Map<List<Product>, List<ProductDTO>>(products.FindAll(x => x.Description.Contains(product), 20).ToList());
            //return products.FindAll(x => x.Description.Contains(product), 20).Select(x => mapper.Map<ProductDTO>(x)).ToList();

            //return products.FindAll(x => x.Description.Contains(product),20).Select(x => new ProductDTO()
            //{
            //    Id = x.Id,
            //    Description = x.Description,
            //}).ToList();
        }



    }
}
