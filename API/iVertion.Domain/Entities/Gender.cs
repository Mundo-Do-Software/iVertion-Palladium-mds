
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Gender : Entity
    {
        public string? Description { get; private set; }
        public char Acronyn { get; private set; }

        public Gender(string description,
                      char acronyn,
                      bool active)
        {
            ValidationDomain(description,
                             acronyn);
            Active  = active;
        }
        public Gender(int id,
                      string description,
                      char acronyn,
                      bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(description,
                             acronyn);
            Id      = id;
            Active  = active;
        }
        public void Update(string description,
                           char acronyn,
                           bool active)
        {
            ValidationDomain(description,
                             acronyn);
            Active  = active;
        }

        private void ValidationDomain(string description,
                                      char acronyn)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                                           "Invalid Description, must not be empty or null.");
            DomainExceptionValidation.When(description.Length < 4,
                                           "Invalid Description, too short, minimum 4 characters.");
            DomainExceptionValidation.When(description.Length > 25,
                                           "Invalid Title, too long, max 25 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(Char.ToString(acronyn)),
                                           "Invalid Acronyn, must not be empty or null.");
            Description = description;
            Acronyn     = acronyn;
        }
    }
}