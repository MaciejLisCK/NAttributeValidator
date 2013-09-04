using System;
using System.Collections.Generic;

namespace NAttributeValidator.Helpers
{
    public class StringToMatrixParser : IStringToMatrixParser
    {
        private readonly string _columnsSeparator;
        private readonly string _rowsSeparator;

        public StringToMatrixParser(string rowsSeparator, string columnsSeparator)
        {
            _columnsSeparator = columnsSeparator;
            _rowsSeparator = rowsSeparator;
        }

        public List<List<string>> Parse(string rawMatrix)
        {
            var result = new List<List<string>>();
            var rows = SplitBy(rawMatrix, _rowsSeparator);

            foreach (var row in rows)
            {
                var columns = SplitBy(row, _columnsSeparator);
                result.Add(new List<string>(columns));
            }

            return result;
        }

        private IEnumerable<string> SplitBy(string text, string separator)
        {
            return text.Split(new[] {separator}, StringSplitOptions.None);
        }
    }
}