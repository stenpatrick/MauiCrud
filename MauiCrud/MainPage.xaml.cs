using MauiCrud.ViewModels;

namespace MauiCrud
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _productsviewModel;
        public MainPage(ProductsViewModel productsViewModel)
        {
            InitializeComponent();
            BindingContext = productsViewModel;
            _productsviewModel = productsViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _productsviewModel.LoadProductsAsync();
        }
    }
}
