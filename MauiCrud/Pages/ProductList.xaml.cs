using MauiCrud.ViewModels;

namespace Pages
{
    public partial class ProductList : ContentPage
    {
        public ProductList()
        {
            InitializeComponent();
            BindingContext = new ProductsViewModel();
        }
    }
}
