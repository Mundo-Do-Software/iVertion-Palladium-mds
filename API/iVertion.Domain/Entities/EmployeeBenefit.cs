using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public class EmployeeBenefit : Entity
    {
        public int EmployeeId { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }
        public int BenefitId { get; private set; }
        public IEnumerable<Benefit>? Benefits { get; set; }

        public EmployeeBenefit(int employeId,
                               int benefitId,
                               bool active)
        {
            ValidationDomain(employeId,
                             benefitId);
            Active  = active;
        }
        public EmployeeBenefit(int id,
                               int employeId,
                               int benefitId,
                               bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(employeId,
                             benefitId);
            Id      = id;
            Active  = active;
        }
        public void Update(int employeId,
                           int benefitId,
                           bool active)
        {
            ValidationDomain(employeId,
                             benefitId);
            Active  = active;
        }

        private void ValidationDomain(int employeId,
                                      int benefitId)
        {
            DomainExceptionValidation.When(employeId <= 0,
                                           "Invalid Employee Id, must be up to zero.");
            DomainExceptionValidation.When(benefitId <= 0,
                                           "Invalid Benefit Id, must be up to zero.");
            EmployeeId  = employeId;
            BenefitId   = benefitId;
        }
    }
}