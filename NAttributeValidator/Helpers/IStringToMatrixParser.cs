using System.Collections.Generic;

namespace BusinessLogic.Helpers
{
    public interface IStringToMatrixParser
    {
        List<List<string>> Parse(string rawMatrix);
    }
}