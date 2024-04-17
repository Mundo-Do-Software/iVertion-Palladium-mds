
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Level : Entity
    {
        public string? Description { get; private set; }
        public char Acronym { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public Level(string description,
                     char acronym,
                     bool active)
        {
            ValidationDomain(description,
                             acronym);
            Active  = active;
        }
        public Level(int id,
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
            DomainExceptionValidation.When(acronym != 'E' && acronym != 'T' && acronym != 'J' && acronym != 'P' && acronym != 'S',
                                           "Invalid Acronym, must be 'E', 'T', 'J', 'P' or 'S'.");
            Description = description;
            Acronym     = acronym;
        }
    }
}