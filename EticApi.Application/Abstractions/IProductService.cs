using EticApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticApi.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
