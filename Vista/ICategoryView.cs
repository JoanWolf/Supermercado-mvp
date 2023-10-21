using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Vista
{
    internal interface ICategoryView
    {
        string CategoryId { get; set; }
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }

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

        void SetCategoryListBildingSource(BindingSource categoryList);
        void Show();
    }
}