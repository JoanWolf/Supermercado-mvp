using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Vista
{
    internal interface IProductsView
    {
        string ProductsId { get; set; }
        string ProductsName { get; set; }
        string ProductsDescription { get; set; }
        double ProductsPrice { get; set; }
        int ProductsStock { get; set; }
        string Products_Category { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductsListBildingSource(BindingSource productsList);
        void Show();
    }
}
