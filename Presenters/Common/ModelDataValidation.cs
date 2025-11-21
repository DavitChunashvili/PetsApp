using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVP_Project.Presenters.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = string.Empty;
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    errorMessage += validationResult.ErrorMessage + Environment.NewLine;
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
