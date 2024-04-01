
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public class BusinessGroup : Entity
    {
        public string? Name { get; private set; }
        public IEnumerable<Company>? Companies { get; set; }

        private void ValidationDomain(string? name)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name),
                                           "Name cannot be null or empty.");
            DomainExceptionValidation.When(name?.Length < 5,
                                           "Name must have at least 5 characters.");
            DomainExceptionValidation.When(name?.Length > 255,
                                           "Name must have a maximum of 255 characters.");

            Name = name;
        }
    }
}