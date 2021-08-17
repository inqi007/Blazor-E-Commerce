using E_commerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Client.Services.CategoryService
{
    interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
