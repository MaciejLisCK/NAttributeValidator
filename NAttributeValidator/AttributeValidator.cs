using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAttributeValidator.Validation.Base;

namespace NAttributeValidator
{
    class AttributeValidator
    {
        private readonly ValidationMessageType _validationTreshold;

        public AttributeValidator(ValidationMessageType validationTreshold = ValidationMessageType.Error)
        {
            _validationTreshold = validationTreshold;
        }


        /// <summary>
        /// Validate object decorated with attributes
        /// </summary>
        /// <param name="objectToValidate"></param>
        /// <returns></returns>
        public ValidationResult Validate(object objectToValidate)
        {
            var result = new ValidationResult(_validationTreshold);




            return result;
        }
    }
}
