using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Supermarket_mvp.Presentador.Common
{
    internal class ModelDataValidation
    {

        public void Validate(object model)
        {

            string errorMesage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(
                model, validationContext, validationResults, true);
            if (isValid==false) 
            {
            
                foreach (var item in validationResults)
                {
                    errorMesage += item.ErrorMessage + "\n";
                }
                throw new Exception (errorMesage);
            }

        }
    }
}
