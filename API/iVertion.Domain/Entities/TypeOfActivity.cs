
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class TypeOfActivity : Entity
    {
        public string? Name { get; private set; }
        public string? ActivityCode { get; private set; }
        public List<CompanyTypeOfActivity>? CompanyTypeOfActivities { get; set; }
        public TypeOfActivity(string name,
                              string activityCode,
                              bool active)
        {
            ValidationDomain(name,
                             activityCode);
            Active = active;

        }
        public TypeOfActivity(int id,
                              string name,
                              string activityCode,
                              bool active)
        {
            DomainExceptionValidation.When(id <= 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(name,
                             activityCode);
            Active = active;

        }
        public void Update(string name,
                           string activityCode,
                           bool active)
        {
            ValidationDomain(name,
                             activityCode);
            Active = active;

        }

        private void ValidationDomain(string? name,
                                      string? activityCode)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name),
                                           "Name cannot be null or empty.");
            DomainExceptionValidation.When(name?.Length < 5,
                                           "Name must have at least 5 characters.");
            DomainExceptionValidation.When(name?.Length > 255,
                                           "Name must have a maximum of 255 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(activityCode),
                                           "ActivityCode cannot be null or empty.");
            DomainExceptionValidation.When(activityCode?.Length < 6,
                                           "ActivityCode must have at least 6 characters.");
            DomainExceptionValidation.When(activityCode?.Length > 9,
                                           "ActivityCode must have a maximum of 9 characters.");

            Name = name;
            ActivityCode = activityCode;
        } 
    }
}