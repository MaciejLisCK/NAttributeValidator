using System.Collections.Generic;
using NAttributeValidator.Helpers;
using NAttributeValidator.Validation.Base;

namespace NAttributeValidator.Validation
{
    public class ExcelPasteOutputValidator
    {
        private readonly IStringToMatrixParser _outputParser;
        private readonly int _expectedColumnsCount;

        public ExcelPasteOutputValidator(IStringToMatrixParser outputParser, int expectedColumnsCount)
        {
            _outputParser = outputParser;
            _expectedColumnsCount = expectedColumnsCount;
        }

        public MatrixValidationResult Validate(string output)
        {
            var matrixValidationResult = new MatrixValidationResult();

            var matrix = _outputParser.Parse(output);
            var columnsLengthValidationMessage = ColumnsLengthValidate(matrix);

            matrixValidationResult.AddMessages(columnsLengthValidationMessage);

            return matrixValidationResult;
        }

        private IEnumerable<MatrixValidationMessage> ColumnsLengthValidate(List<List<string>> matrix)
        {
            var validationMessages = new List<MatrixValidationMessage>();

            for (int i = 0; i < matrix.Count; i++)
            {
                var row = matrix[i];
                var columnsCount = row.Count;
                if (columnsCount != _expectedColumnsCount)
                {
                    var validationMessage = new MatrixValidationMessage(ValidationMessageType.Error);
                    validationMessage.RowNumber = i + 1;

                    validationMessages.Add(validationMessage);
                }
            }

            return validationMessages;
        }
    }
}
