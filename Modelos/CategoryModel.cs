using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Modelos
{
    internal class CategoryModel
    {
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]

        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
