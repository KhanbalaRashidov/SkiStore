﻿using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository(RepositoryContext repositoryContext) : RepositoryBase<Product>(repositoryContext), IProductRepository
    {
    }
}
