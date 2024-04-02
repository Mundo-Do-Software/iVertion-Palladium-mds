
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class TypeOfOrganizationalStructure : Entity
    {
        public string? Name { get; private set; }
        public IEnumerable<BusinessGroup>? BusinessGroups { get; set; }
        public TypeOfOrganizationalStructure(string name,
                                             bool active)
        {
            ValidationDomain(name);
            Active = active;

        }
        public TypeOfOrganizationalStructure(int id,
                                             string name,
                                             bool active)
        {
            DomainExceptionValidation.When(id <= 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(name);
            Active = active;

        }
        public void Update(string name,
                           bool active)
        {
            ValidationDomain(name);
            Active = active;

        }

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