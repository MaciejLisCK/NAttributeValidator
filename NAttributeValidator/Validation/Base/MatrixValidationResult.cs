namespace NAttributeValidator.Validation.Base
{
    public class MatrixValidationResult : ValidationResultBase<MatrixValidationMessage>
    {
        public MatrixValidationResult(ValidationMessageType validationTreshold = ValidationMessageType.Error) 
            : base(validationTreshold)
        { }
    }
}