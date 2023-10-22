using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Modelos
{
    internal class ProvidersModel
    {
        [DisplayName("providers Id")]
        public int Id { get; set; }

        [DisplayName("providers Name")]
        [Required(ErrorMessage = "providers name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "providers name must be between 3 and 50 characters")]

        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "providers Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "providers observation must be between 3 and 200 characters")]
        public string Description { get; set; }
    }
}
