

using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public class WorkModel : Entity
    {
        public string? Description { get; private set; }
        public string? Acronym { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public WorkModel(string description,
                         string acronym,
                         bool active)
        {
            ValidationDomain(description,
                             acronym);
            Active  = active;
        }
        public WorkModel(int id,
                         string description,
                         string acronym,
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
                           string acronym,
                           bool active)
        {
            ValidationDomain(description,
                             acronym);
            Active  = active;
        }

        private void ValidationDomain(string description,
                                      string acronym)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                                           "Invalid Description, must not be empty or null.");
            DomainExceptionValidation.When(description.Length < 4,
                                           "Invalid Description, too short, minimum 4 stringacters.");
            DomainExceptionValidation.When(description.Length > 25,
                                           "Invalid Description, too long, max 25 stringacters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(acronym),
                                           "Invalid Acronym, must not be empty or null.");
            DomainExceptionValidation.When(acronym.Length < 1,
                                           "Invalid Acronym, too short, minimum 1 stringacters.");
            DomainExceptionValidation.When(acronym.Length > 5,
                                           "Invalid Acronym, too long, max 5 stringacters.");

            Description = description;
            Acronym     = acronym;
        }
    }
}