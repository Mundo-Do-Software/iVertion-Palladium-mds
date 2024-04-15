
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Employee : Entity
    {
        // Personal information.
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? NameInitials { get; private set; }
        public string? SocialName { get; private set; }
        public string? Cpf { get; private set; }
        public string? Pis { get; private set; }
        public string? Ctps { get; private set; }
        public string? Series { get; private set; }
        public string? Rg { get; private set; }
        public string? Cnh { get; private set; }
        public string? VoterRegistration { get; private set; }
        public string? ElectoralZone { get; private set; }
        public string? ElectoraSection { get; private set; }

        // Dates of birth and admission.
        public DateOnly Birthday { get; private set; }
        public DateOnly AdmissionDate { get; private set; }
        public DateOnly ResignationDate { get; private set; }

        // Identification properties for relationships.
        public int GenderId { get; private set; }
        public int CivilStatusId { get; private set; }
        public int DepartmentId { get; private set; }
        public int LevelId { get; private set; }
        public int ProfessionId { get; private set; }
        public int RemunerationId { get; private set; }
        public int WorkModelId { get; private set; }
        public int? MedicalRecordId { get; private set; }

        // Emergency contact properties.
        public string? EmergencyContactName { get; private set; }
        public string? EmergencyContactPhoneNumber { get; private set; }

        // Related user.
        public string? TargetUserId { get; private set; }

        // Relationship properties.
        public Gender? Gender { get; set; }
        public CivilStatus? CivilStatus { get; set; }
        public Department? Department { get; set; }
        public Level? Level { get; set; }
        public Profession? Profession { get; set; }
        public Remuneration? Remuneration { get; set; }
        public WorkModel? WorkModel { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }

        // Collection relationship properties.
        public List<EmployeeAddress>? EmployeeAddresses { get; set; }
        public IEnumerable<Skill>? Skills { get; set; }
        public List<EmployeeBenefit>? EmployeeBenefits { get; set; }
        public IEnumerable<EmployeeHistory>? EmployeeHistories { get; set; }
        public IEnumerable<EmployeePerformance>? EmployeePerformances { get; set; }
        public IEnumerable<RemunerationHistory>? RemunerationHistories { get; set; }
        public IEnumerable<VacancyRequirement>? VacancyRequirements { get; set; }
        public IEnumerable<Vacation>? Vacations { get; set; }
        public IEnumerable<CheckPoint>? CheckPoints { get; set; }
        public IEnumerable<Document>? Documents { get; set; }
        public IEnumerable<Occurrence>? Occurrences { get; set; }
        public IEnumerable<Payroll>? Payrolls { get; set; }
        public IEnumerable<Dependent>? Dependents { get; set; }
        public IEnumerable<MedicalExam>? MedicalExams { get; set; }

        public Employee(string firstName,
                        string lastName,
                        string nameInitials,
                        string socialName,
                        string cpf,
                        string pis,
                        string ctps,
                        string series,
                        string rg,
                        string cnh,
                        string voterRegistration,
                        string electoralZone,
                        string electoralSection,
                        DateOnly birthday,
                        DateOnly admissionDate,
                        DateOnly resignationDate,
                        int genderId,
                        int civilStatusId,
                        int departmentId,
                        int levelId,
                        int professionId,
                        int remunerationId,
                        int workModelId,
                        int? medicalRecordId,
                        string? emergencyContactName,
                        string? emergencyContactPhoneNumber,
                        string? targetUserId,
                        bool active)
        {
            ValidationDomain(firstName,
                             lastName,
                             nameInitials,
                             socialName,
                             cpf,
                             pis,
                             ctps,
                             series,
                             rg,
                             cnh,
                             voterRegistration,
                             electoralZone,
                             electoralSection,
                             birthday,
                             admissionDate,
                             resignationDate,
                             genderId,
                             civilStatusId,
                             departmentId,
                             levelId,
                             professionId,
                             remunerationId,
                             workModelId,
                             medicalRecordId,
                             emergencyContactName,
                             emergencyContactPhoneNumber,
                             targetUserId);
            Active  = active;
        }

        public Employee(int id,
                        string firstName,
                        string lastName,
                        string nameInitials,
                        string socialName,
                        string cpf,
                        string pis,
                        string ctps,
                        string series,
                        string rg,
                        string cnh,
                        string voterRegistration,
                        string electoralZone,
                        string electoralSection,
                        DateOnly birthday,
                        DateOnly admissionDate,
                        DateOnly resignationDate,
                        int genderId,
                        int civilStatusId,
                        int departmentId,
                        int levelId,
                        int professionId,
                        int remunerationId,
                        int workModelId,
                        int? medicalRecordId,
                        string? emergencyContactName,
                        string? emergencyContactPhoneNumber,
                        string? targetUserId,
                        bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(firstName,
                             lastName,
                             nameInitials,
                             socialName,
                             cpf,
                             pis,
                             ctps,
                             series,
                             rg,
                             cnh,
                             voterRegistration,
                             electoralZone,
                             electoralSection,
                             birthday,
                             admissionDate,
                             resignationDate,
                             genderId,
                             civilStatusId,
                             departmentId,
                             levelId,
                             professionId,
                             remunerationId,
                             workModelId,
                             medicalRecordId,
                             emergencyContactName,
                             emergencyContactPhoneNumber,
                             targetUserId);
            Id      = id;
            Active  = active;
        }

        public void Update(string firstName,
                           string lastName,
                           string nameInitials,
                           string socialName,
                           string cpf,
                           string pis,
                           string ctps,
                           string series,
                           string rg,
                           string cnh,
                           string voterRegistration,
                           string electoralZone,
                           string electoralSection,
                           DateOnly birthday,
                           DateOnly admissionDate,
                           DateOnly resignationDate,
                           int genderId,
                           int civilStatusId,
                           int departmentId,
                           int levelId,
                           int professionId,
                           int remunerationId,
                           int workModelId,
                           int? medicalRecordId,
                           string? emergencyContactName,
                           string? emergencyContactPhoneNumber,
                           string? targetUserId,
                           bool active)
        {
            ValidationDomain(firstName,
                             lastName,
                             nameInitials,
                             socialName,
                             cpf,
                             pis,
                             ctps,
                             series,
                             rg,
                             cnh,
                             voterRegistration,
                             electoralZone,
                             electoralSection,
                             birthday,
                             admissionDate,
                             resignationDate,
                             genderId,
                             civilStatusId,
                             departmentId,
                             levelId,
                             professionId,
                             remunerationId,
                             workModelId,
                             medicalRecordId,
                             emergencyContactName,
                             emergencyContactPhoneNumber,
                             targetUserId);
            Active  = active;
        }

        private void ValidationDomain(string firstName,
                                      string lastName,
                                      string nameInitials,
                                      string socialName,
                                      string cpf,
                                      string pis,
                                      string ctps,
                                      string series,
                                      string rg,
                                      string cnh,
                                      string voterRegistration,
                                      string electoralZone,
                                      string electoralSection,
                                      DateOnly birthday,
                                      DateOnly admissionDate,
                                      DateOnly resignationDate,
                                      int genderId,
                                      int civilStatusId,
                                      int departmentId,
                                      int levelId,
                                      int professionId,
                                      int remunerationId,
                                      int workModelId,
                                      int? medicalRecordId,
                                      string? emergencyContactName,
                                      string? emergencyContactPhoneNumber,
                                      string? targetUserId)
        {
            DateTime datenow = DateTime.Now;
            DateOnly dateonlynow = new DateOnly(datenow.Year, datenow.Month, datenow.Day);
            DomainExceptionValidation.When(String.IsNullOrEmpty(firstName),
                                           "Invalid First Name, not be null or empty.");
            DomainExceptionValidation.When(firstName.Length < 2,
                                           "Invalid First Name, to short, minimum 2 characters.");
            DomainExceptionValidation.When(firstName.Length > 40,
                                           "Invalid First Name, to long, max 40 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(lastName),
                                           "Invalid Last Name, not be null or empty.");
            DomainExceptionValidation.When(lastName.Length < 2,
                                           "Invalid Last Name, to short, minimum 2 characters.");
            DomainExceptionValidation.When(lastName.Length > 255,
                                           "Invalid Last Name, to long, max 255 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(nameInitials),
                                           "Invalid Name Initials, not be null or empty.");
            DomainExceptionValidation.When(nameInitials.Length < 2,
                                           "Invalid Name Initials, to short, minimum 2 characters.");
            DomainExceptionValidation.When(nameInitials.Length > 10,
                                           "Invalid Name Initials, to long, max 10 characters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(socialName),
                                           "Invalid Social Name, not be null or empty.");
            DomainExceptionValidation.When(socialName.Length < 2,
                                           "Invalid Social Name, to short, minimum 2 characters.");
            DomainExceptionValidation.When(socialName.Length > 40,
                                           "Invalid Social Name, to long, max 40 characters.");
            DomainExceptionValidation.When(!IdentityValidation.ValidateCpf(cpf),
                                           "Invalid CPF.");
            DomainExceptionValidation.When(!IdentityValidation.ValidatePisPasep(pis),
                                           "Invalid PIS - PASEP.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(ctps),
                                           "Invalid Ctps, not be null or empty.");
            DomainExceptionValidation.When(ctps.Length < 7 || ctps.Length > 7,
                                           "Invalid Ctps, must be 7 caracters.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(series),
                                           "Invalid Series, not be null or empty.");
            DomainExceptionValidation.When(series.Length < 1 || series.Length > 4,
                                           "Invalid Series, minimum 1 and max 4 caracters.");
            DomainExceptionValidation.When(!IdentityValidation.ValidateRgNumber(rg),
                                           "Invalid Identity Document.");
            DomainExceptionValidation.When(!IdentityValidation.ValidateCnhNumber(cnh),
                                           "Invalid driver's license.");
            DomainExceptionValidation.When(!IdentityValidation.ValidateVoterRegistration(voterRegistration, electoralZone, electoralSection),
                                           "Invalid voter registration card.");
            DomainExceptionValidation.When(birthday < dateonlynow,
                                           "Invalid birth date, cannot be less than the current day.");
            if(resignationDate != default(DateOnly)){
                DomainExceptionValidation.When(admissionDate > resignationDate,
                                               "The hire date cannot be greater than the dismissal date.");
            }
            DomainExceptionValidation.When(genderId <= 0,
                                           "Invalid Gender Id, must be up to zero.");
            DomainExceptionValidation.When(civilStatusId <= 0,
                                           "Invalid Civil Status Id, must be up to zero.");
            DomainExceptionValidation.When(departmentId <= 0,
                                           "Invalid Department Id, must be up to zero.");
            DomainExceptionValidation.When(levelId <= 0,
                                           "Invalid Level Id, must be up to zero.");
            DomainExceptionValidation.When(professionId <= 0,
                                           "Invalid Profession Id, must be up to zero.");
            DomainExceptionValidation.When(remunerationId <= 0,
                                           "Invalid Remunaration Id, must be up to zero.");
            DomainExceptionValidation.When(workModelId <= 0,
                                           "Invalid Work Model Id, must be up to zero.");
            if(medicalRecordId != null){
                DomainExceptionValidation.When(medicalRecordId <= 0,
                                            "Invalid Work Model Id, must be up to zero.");
            }

            FirstName                   = firstName;
            LastName                    = lastName;
            NameInitials                = nameInitials;
            SocialName                  = socialName;
            Cpf                         = cpf;
            Pis                         = pis;
            Ctps                        = ctps;
            Series                      = series;
            Rg                          = rg;
            Cnh                         = cnh;
            VoterRegistration           = voterRegistration;
            ElectoralZone               = electoralZone;
            ElectoraSection             = electoralSection;
            Birthday                    = birthday;
            AdmissionDate               = admissionDate;
            ResignationDate             = resignationDate;
            GenderId                    = genderId;
            CivilStatusId               = civilStatusId;
            DepartmentId                = departmentId;
            MedicalRecordId             = medicalRecordId;
            EmergencyContactName        = emergencyContactName;
            EmergencyContactPhoneNumber = emergencyContactPhoneNumber;
            TargetUserId                = targetUserId;
        }
    }
}