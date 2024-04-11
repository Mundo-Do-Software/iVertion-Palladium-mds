
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
    }
}