
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class CivilStatus : Entity
    {
        public string? Description { get; private set; }
        public char Acronym { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public CivilStatus(string description,
                           char acronym,
                           bool active)
        {
            ValidationDomain(description,
                             acronym);
            Active  = active;
        }
        public CivilStatus(int id,
                           string description,
                           char acronym,
                           bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(description,
                             acronym);
            Id      = id;
            Active  = active;
        }
        public void Update(string description,
                           char acronym,
                           bool active)
        {
            ValidationDomain(description,
                             acronym);
            Active  = active;
        }

        private void ValidationDomain(string description,
                                      char acronym)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                                           "Invalid Description, must not be empty or null.");
            DomainExceptionValidation.When(description.Length < 4,
                                           "Invalid Description, too short, minimum 4 characters.");
            DomainExceptionValidation.When(description.Length > 25,
                                           "Invalid Description, too long, max 25 characters.");
            DomainExceptionValidation.When(acronym != 'S' && acronym != 'C' && acronym != 'V' && acronym != 'D',
                                           "Invalid Acronym, must be 'S', 'C', 'V' or 'D'.");
            Description = description;
            Acronym     = acronym;
        }
    }
}