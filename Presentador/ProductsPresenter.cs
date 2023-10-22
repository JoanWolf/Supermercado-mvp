using Supermarket_mvp.Modelos;
using Supermarket_mvp.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presentador
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEditProducts;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);

            loadAllProductsList();

            this.view.Show();
        }
        private void loadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            //Se rea un objeto de laclase Productsl y se asinan los datos de las cajas de texto
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            products.Price = Convert.ToInt32(view.ProductsPrice);
            products.Stock = Convert.ToInt32(view.ProductsStock);
            products.Category_Id = Convert.ToInt32(view.Products_IdCategory.Substring(0, 6));
            

            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Products edited succesfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Products added succesfuly";
                }
            }
            catch (Exception ex)
            {
                // si ocurre una excepcion se configura IsSuccesfull en flase
                // y a la propiedad message de la vista se asigna el mensaje de la excepcion
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
            view.IsSuccesful = true;
            loadAllProductsList();
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)productsBindingSource.Current;

                repository.Delete(products.Id);
                view.IsSuccesful = true;
                view.Message = "Products deleted successfully";
                loadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProductsToEditProducts(object? sender, EventArgs e)
        {
            //se obtiene el objeto datagridview que se necuentra selccionado
            var Products = (ProductsModel)productsBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagridview
            view.ProductsId = Products.Id.ToString();
            view.ProductsName = Products.Name;
            view.ProductsPrice = Products.Price.ToString();
            view.ProductsPrice = Products.Stock.ToString();

            //Se establece el modo como edicion

            view.IsEdit = true;

        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            //MessageBox.Show("Hizo clic en el boton nuevo");
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }
    }
}
