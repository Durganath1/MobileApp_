using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace a1ExpressVol_1
{
    public class MainViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Title = "Job No 1",
                    IsVisible = false
                },
                new Product
                {
                    Title = "Job No 2",
                },
                new Product
                {
                    Title = "Job No 3"
                }
            };
        }
        public void HideOrShowProduct(Product product)
        {
            product.IsVisible = true;
            UpdateProducts(product);
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
