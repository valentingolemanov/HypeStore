using StreetwearStore.Data.Entities;
using StreetwearStore.Data.Repository;
using StreetwearStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace StreetwearStore.Services.Categories
{

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> repository;

        public CategoriesService(IDeletableEntityRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(string name, string description, string imageUrl)
        {
            var category = this.GetCategoryByName(name);
            if(repository != null)
            {
                return -1;
            }

            category = new Category
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl
            };

            await this.repository.AddAsync(category);
            await this.repository.SaveChangesAsync();

            return category.Id;

           
        }

        public async Task Delete(int id)
        {
            var category = this.GetCategoryById(id);
            if(category == null)
            {
                return;
            }

            this.repository.Delete(category);
            await this.repository.SaveChangesAsync();
            
        }

        public TModel GetById<TModel>(int id)
        {
            return this.repository.All()
               .Where(x => x.Id == id)
               .To<TModel>()
               .FirstOrDefault();
        }

        public ICollection<TModel> GetCategories<TModel>()
        {
            return this.repository.All()
                .To<TModel>()
                .ToList();
        }

        private Category GetCategoryByName(string name)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }

        private Category GetCategoryById(int id)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
