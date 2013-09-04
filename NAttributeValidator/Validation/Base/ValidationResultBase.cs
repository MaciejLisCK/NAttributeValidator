using System.Collections.Generic;
using System.Linq;

namespace NAttributeValidator.Validation.Base
{
    public abstract class ValidationResultBase<T> where T: ValidationMessage
    {
        private readonly ValidationMessageType _validationTreshold;
        private readonly List<T> _messages = new List<T>();

        public IEnumerable<T> Messages
        {
            get { return _messages; }
        }

        private IEnumerable<T> ValidMessages
        {
            get
            {
                return Messages.Where(m => m.Type < _validationTreshold);
            }
        }

        private IEnumerable<T> NotValidMessages
        {
            get
            {
                return Messages.Where(m => !ValidMessages.Contains(m));
            }
        }

        public bool IsValid
        {
            get
            {
                return NotValidMessages.Any();
            }
        }

        public ValidationResultBase(ValidationMessageType validationTreshold = ValidationMessageType.Error)
        {
            _validationTreshold = validationTreshold;
        }

        public void AddMessage(T message)
        {
            _messages.Add(message);
        }

        public void AddMessages(IEnumerable<T> messages)
        {
            foreach (var message in messages)
                AddMessage(message);
        }

    }
}