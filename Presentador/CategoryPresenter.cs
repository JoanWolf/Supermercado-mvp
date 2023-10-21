using Supermarket_mvp.Modelos;
using Supermarket_mvp.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presentador
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectCategoryToEditCategory;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBildingSource(categoryBindingSource);

            loadAllCategoryList();

            this.view.Show();
        }

        private void loadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            //Se rea un objeto de laclase Categoryl y se asinan los datos de las cajas de texto
            var category = new CategoryModel();
            category.Id = Convert.ToInt32(view.CategoryId);
            category.Name = view.CategoryName;
            category.Observation = view.CategoryObservation;

            try
            {
                new Common.ModelDataValidation().Validate(category);
                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Category edited succesfuly";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Category added succesfuly";
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
            loadAllCategoryList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryObservation = "";
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;

                repository.Delete(category.Id);
                view.IsSuccesful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectCategoryToEditCategory(object? sender, EventArgs e)
        {
            //se obtiene el objeto datagridview que se necuentra selccionado
            var Category = (CategoryModel)categoryBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagridview
            view.CategoryId = Category.Id.ToString();
            view.CategoryName = Category.Name;
            view.CategoryObservation = Category.Observation;

            //Se establece el modo como edicion

            view.IsEdit = true;

        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            //MessageBox.Show("Hizo clic en el boton nuevo");
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;
        }
    }
}
