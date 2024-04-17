
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Department : Entity
    {
        public string? Description { get; private set; }
        public string? Acronym { get; private set; }
        public int CompanyId { get; private set; }
        public Company? Company { get; set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public Department(string description,
                          string acronym,
                          int companyId,
                          bool active)
        {
            ValidationDomain(description,
                             acronym,
                             companyId);
            Active  = active;
        }
        public Department(int id,
                          string description,
                          string acronym,
                          int companyId,
                          bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(description,
                             acronym,
                             companyId);
            Id      = id;
            Active  = active;
        }
        public void Update(string description,
                           string acronym,
                           int companyId,
                           bool active)
        {
            ValidationDomain(description,
                             acronym,
                             companyId);
            Active  = active;
        }

        private void ValidationDomain(string description,
                                      string acronym,
                                      int companyId)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                                           "Invalid Description, must not be empty or null.");
            DomainExceptionValidation.When(description.Length < 4,
                                           "Invalid Description, too short, minimum 4 characters.");
            DomainExceptionValidation.When(description.Length > 25,
                                           "Invalid Description, too long, max 25 characters.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(acronym),
                                           "Invalid Name, must not be null or empity.");
            DomainExceptionValidation.When(acronym.Length < 1,
                                           "Invalid Name, too short, must be 1 or more characters.");
            DomainExceptionValidation.When(acronym.Length > 5,
                                           "Invalid Name, too long, must be up to 5 characters.");
            DomainExceptionValidation.When(companyId < 0,
                                           "Invalid Company Id, must be up to zero.");
            Description = description;
            Acronym     = acronym;
            CompanyId   = companyId;
        }
    }
}