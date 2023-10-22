using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Modelos
{
    internal class ProductsModel
    {
        [DisplayName("Products Id")]
        public int Id { get; set; }

        [DisplayName("Products Name")]
        [Required(ErrorMessage = "Products name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Products name must be between 3 and 80 characters")]
        public string Name { get; set; }


        [DisplayName("Description")]
        [Required(ErrorMessage = "Products Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Products observation must be between 3 and 200 characters")]
        public string description { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get; set; }

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        public int Category_Id { get; set; }


    }
}
