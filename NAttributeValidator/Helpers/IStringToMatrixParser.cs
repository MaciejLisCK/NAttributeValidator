using System.Collections.Generic;

namespace NAttributeValidator.Helpers
{
    public interface IStringToMatrixParser
    {
        List<List<string>> Parse(string rawMatrix);
    }
}