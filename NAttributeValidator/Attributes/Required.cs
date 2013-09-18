using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAttributeValidator.Attributes
{
    [System.AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class Required : Attribute, IValidationAttribute
    {
        public object EmptyValue { get; set; }

        public bool IsValid(object value)
        {
            if (value == null)
                return false;
            if (value == EmptyValue)
                return false;


            return true;
        }
    }
}
