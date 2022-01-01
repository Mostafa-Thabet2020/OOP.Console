using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain
{
    public class DateSeeding
    {
        public SubCategory GetSubCategories()
        {
            Category ElecCategory = new Category();//Instance of category
            ElecCategory.ID=1;
            ElecCategory.Name ="Electronic";
            ElecCategory.CreatedDate = new DateTime(2021,11,20);

            List<SubCategory> subCategories = new List<SubCategory>();

            SubCategory TvSubCategory = new SubCategory();//Instance of SubCategory
            TvSubCategory.ID=1;
            TvSubCategory.Name ="TV";
            TvSubCategory.CreatedDate=new DateTime(2021, 12, 20);
            TvSubCategory.category=ElecCategory;

            return TvSubCategory;
        }

        public Brand GetBrand()
        {
            Brand brand = new Brand()
            {
                ID=1,
                Name="Samsong",
                CreatedDate=new DateTime(2015, 12, 20),
                IsDisplay=true
            };
            return brand;
        }
        public List< Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            
            Product LedTV = new Product()
            {
                ID = 1,
                Name ="Smart LED TV",
                IsDisplay=true,
                IsSale=false,
                subCategory=GetSubCategories(),
                brand=GetBrand()
            };

            Product Neo = new Product()
            {
                ID = 2,
                Name ="Neo QLED 4K ",
                IsDisplay=true,
                IsSale=false,
                subCategory=GetSubCategories(),
                brand=GetBrand()
            };

            products.Add(LedTV);
            products.Add(Neo);

            Product.NumberOfProduct=products.Count;

            return products;
            
        }
    }
}
