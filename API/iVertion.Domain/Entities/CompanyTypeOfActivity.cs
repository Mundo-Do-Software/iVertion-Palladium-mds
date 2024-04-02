
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class CompanyTypeOfActivity : Entity
    {
        public int CompanyId { get; private set; }
        public int TypeOfActivityId { get; private set; }
        public bool IsPrimary { get; private set; }
        public Company? Company { get; set; }
        public TypeOfActivity? TypeOfActivity { get; set; }

        public CompanyTypeOfActivity(int companyId,
                                    int typeOfActivityId,
                                    bool isPrimary,
                                    bool active)
        {
            ValidationDomain(companyId,
                            typeOfActivityId);
            IsPrimary   = isPrimary;
            Active      = active;
        }
        public CompanyTypeOfActivity(int id,
                                    int companyId,
                                    int typeOfActivityId,
                                    bool isPrimary,
                                    bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                            "Invalid Id, must be up to zero.");
            ValidationDomain(companyId,
                            typeOfActivityId);
            IsPrimary   = isPrimary;
            Active      = active;
        }
        public void Update(int companyId,
                        int typeOfActivityId,
                        bool isPrimary,
                        bool active)
        {
            ValidationDomain(companyId,
                            typeOfActivityId);
            IsPrimary   = isPrimary;
            Active      = active;
        }
        private void ValidationDomain(int companyId,
                                    int typeOfActivityId)
        {
            DomainExceptionValidation.When(companyId <= 0,
                                        "Invalid Company Id, must be up to zero.");
            DomainExceptionValidation.When(typeOfActivityId <= 0,
                                        "Invalid Type Of Activity Id, must be up to zero.");

            CompanyId           = companyId;
            TypeOfActivityId    = typeOfActivityId;
        
        }
    }
}