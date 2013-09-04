namespace BusinessLogic.Validation.Base
{
    public class MatrixValidationMessage : ValidationMessage
    {
        public MatrixValidationMessage(ValidationMessageType type) 
            : base(type)
        { }

        public int ColumnNumber { get; set; }
        public int RowNumber { get; set; }
    }
}