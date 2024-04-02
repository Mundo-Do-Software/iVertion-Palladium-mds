
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Company : Entity
    {
        public string? CorporateName { get; private set; }
        public string? BusinessName { get; private set; }
        public string? Cnpj { get; private set; }
        public string? StateRegistration { get; private set; }
        public string? BusinesLicense { get; private set; }
        public int TypeOfCompanyId { get; private set; }
        public TypeOfCompany? TypeOfCompany { get; set; }
        public int? BusinessGroupId { get; private set; }
        public BusinessGroup? BusinessGroup { get; set; }
        public int TypeOfRegistrationStatusId { get; private set; }
        public TypeOfRegistrationStatus? TypeOfRegistrationStatus { get; set; }
        public int TypeOfLegalStatuteId { get; private set; }
        public TypeOfLegalStatute? TypeOfLegalStatute { get; set; }
        public List<CompanyTypeOfActivity>? CompanyTypeOfActivities { get; set; }
        public List<CompanyAddress>? CompanyAddresses { get; set; }
        public IEnumerable<Department>? Departments { get; set; }

        public Company(string? corporateName,
                       string? businessName,
                       string cnpj,
                       string? stateRegistration,
                       string? businesLicense,
                       int typeOfCompanyId,
                       int? businessGroupId,
                       int typeOfRegistrationStatusId,
                       int typeOfLegalStatuteId,
                       bool active)
        {
            ValidationDomain(corporateName,
                             businessName,
                             cnpj,
                             stateRegistration,
                             businesLicense,
                             typeOfCompanyId,
                             businessGroupId,
                             typeOfRegistrationStatusId,
                             typeOfLegalStatuteId);
            Active = active;
        }
        public Company(int id,
                       string? corporateName,
                       string? businessName,
                       string cnpj,
                       string? stateRegistration,
                       string? businesLicense,
                       int typeOfCompanyId,
                       int? businessGroupId,
                       int typeOfRegistrationStatusId,
                       int typeOfLegalStatuteId,
                       bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero."); 
            ValidationDomain(corporateName,
                             businessName,
                             cnpj,
                             stateRegistration,
                             businesLicense,
                             typeOfCompanyId,
                             businessGroupId,
                             typeOfRegistrationStatusId,
                             typeOfLegalStatuteId);
            Id = id;                             
            Active = active;
        }
        public void Update(string? corporateName,
                           string? businessName,
                           string cnpj,
                           string? stateRegistration,
                           string? businesLicense,
                           int typeOfCompanyId,
                           int? businessGroupId,
                           int typeOfRegistrationStatusId,
                           int typeOfLegalStatuteId,
                           bool active)
        {
            ValidationDomain(corporateName,
                             businessName,
                             cnpj,
                             stateRegistration,
                             businesLicense,
                             typeOfCompanyId,
                             businessGroupId,
                             typeOfRegistrationStatusId,
                             typeOfLegalStatuteId);
            Active = active;
        }

        private void ValidationDomain(string? corporateName,
                                      string? businessName,
                                      string cnpj,
                                      string? stateRegistration,
                                      string? businesLicense,
                                      int typeOfCompanyId,
                                      int? businessGroupId,
                                      int typeOfRegistrationStatusId,
                                      int typeOfLegalStatuteId)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(corporateName),
                                           "Invalid Corporate Name, must not be empty or null.");
            DomainExceptionValidation.When(corporateName?.Length < 5,
                                           "Invalid Corporate Name, too short, minimum 5 characters.");
            DomainExceptionValidation.When(corporateName?.Length > 255,
                                           "Invalid Corporate Name, too long, max 255 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(businessName),
                                           "Invalid Business Name, must not be empty or null.");
            DomainExceptionValidation.When(businessName?.Length < 5,
                                           "Invalid Business Name, too short, minimum 5 characters.");
            DomainExceptionValidation.When(businessName?.Length > 255,
                                           "Invalid Business Name, too long, max 255 characters.");
            DomainExceptionValidation.When(!IdentityValidation.CnpjVaidator(cnpj),
                                           "Invalid CNPJ.");
            if (!String.IsNullOrEmpty(stateRegistration))
            {
                DomainExceptionValidation.When(stateRegistration?.Length < 5,
                                            "Invalid State Registration, too short, minimum 5 characters.");
                DomainExceptionValidation.When(stateRegistration?.Length > 50,
                                            "Invalid State Registration, too long, max 50 characters.");
            }
            if (!String.IsNullOrEmpty(businesLicense))
            {
                DomainExceptionValidation.When(businesLicense?.Length < 5,
                                            "Invalid Busines License, too short, minimum 5 characters.");
                DomainExceptionValidation.When(businesLicense?.Length > 50,
                                            "Invalid Busines License, too long, max 50 characters.");
            }
            DomainExceptionValidation.When(typeOfCompanyId <= 0,
                                           "Invalid Type Of Company Id, must be up to zero.");
            if (businessGroupId != null){
                DomainExceptionValidation.When(businessGroupId <= 0,
                                            "Invalid Business Group Id, must be up to zero.");
            }
            DomainExceptionValidation.When(typeOfRegistrationStatusId <= 0,
                                           "Invalid Type Of Registration Status Id, must be up to zero.");
            DomainExceptionValidation.When(typeOfLegalStatuteId <= 0,
                                           "Invalid Type Of Registration Status Id, must be up to zero.");

            CorporateName               = corporateName;
            BusinessName                = businessName;
            Cnpj                        = cnpj;
            StateRegistration           = stateRegistration;
            BusinesLicense              = businesLicense;
            TypeOfCompanyId             = typeOfCompanyId;
            BusinessGroupId             = businessGroupId;
            TypeOfRegistrationStatusId  = typeOfRegistrationStatusId;
            TypeOfLegalStatuteId        = typeOfLegalStatuteId;

        }

    }
}