using Supermarket_mvp.Modelos;
using Supermarket_mvp.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presentador
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEditProviders;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);

            loadAllProvidersList();

            this.view.Show();
        }
        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            //Se rea un objeto de laclase Providersl y se asinan los datos de las cajas de texto
            var providers = new ProvidersModel();
            providers.Id = Convert.ToInt32(view.ProvidersId);
            providers.Name = view.ProvidersName;
            providers.Description = view.ProvidersDescription;

            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "Providers edited succesfuly";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Providers added succesfuly";
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
            loadAllProvidersList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersDescription = "";
        }

        private void DeleteSelectedProviders(object? sender, EventArgs e)
        {
            try
            {
                var providers = (ProvidersModel)providersBindingSource.Current;

                repository.Delete(providers.Id);
                view.IsSuccesful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProvidersToEditProviders(object? sender, EventArgs e)
        {
            //se obtiene el objeto datagridview que se necuentra selccionado
            var Providers = (ProvidersModel)providersBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagridview
            view.ProvidersId = Providers.Id.ToString();
            view.ProvidersName = Providers.Name;
            view.ProvidersDescription = Providers.Description;

            //Se establece el modo como edicion

            view.IsEdit = true;

        }
        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            //MessageBox.Show("Hizo clic en el boton nuevo");
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }

    }
}
