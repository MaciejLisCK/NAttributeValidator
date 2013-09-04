namespace BusinessLogic.Validation.Base
{
    public class ValidationResult : ValidationResultBase<ValidationMessage>
    {
        public ValidationResult(ValidationMessageType validationTreshold = ValidationMessageType.Error) 
            : base(validationTreshold)
        {
            
        }

    }
}