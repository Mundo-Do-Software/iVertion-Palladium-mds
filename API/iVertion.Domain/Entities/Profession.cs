
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Profession : Entity
    {
        public string? Description { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public Profession(string description,
                          bool active)
        {
            ValidationDomain(description);
            Active  = active;
        }
        public Profession(int id,
                          string description,
                          bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(description);
            Id      = id;
            Active  = active;
        }
        public void Update(string description,
                           bool active)
        {
            ValidationDomain(description);
            Active  = active;
        }

        private void ValidationDomain(string description)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                                           "Invalid Description, must not be empty or null.");
            DomainExceptionValidation.When(description.Length < 4,
                                           "Invalid Description, too short, minimum 4 characters.");
            DomainExceptionValidation.When(description.Length > 25,
                                           "Invalid Description, too long, max 25 characters.");
            Description = description;
        }
    }
}