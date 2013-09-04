namespace BusinessLogic.Validation.Base
{
    public class ValidationMessage
    {
        public ValidationMessage(ValidationMessageType type)
        {
            Type = type;
        }

        public ValidationMessageType Type { get; private set; }
        public string Message { get; set; }
    }
}