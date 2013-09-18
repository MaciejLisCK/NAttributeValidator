using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAttributeValidator.Attributes
{
    public interface IValidationAttribute
    {
        bool IsValid(object value);
    }
}
