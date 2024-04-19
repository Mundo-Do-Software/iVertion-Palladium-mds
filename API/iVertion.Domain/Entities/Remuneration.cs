
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Remuneration : Entity
    {
        public decimal GrossSalary { get; private set; }
        public int EmployeeId { get; private set; }
        public Employee? Employee { get; set; }
        public Remuneration(decimal grossSalary,
                            int employeId,
                            bool active)
        {
            ValidationDomain(grossSalary,
                             employeId);
            Active  = active;
        }
        public Remuneration(int id,
                            decimal grossSalary,
                            int employeId,
                            bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(grossSalary,
                             employeId);
            Id      = id;
            Active  = active;
        }
        public void Update(decimal grossSalary,
                           int employeId,
                           bool active)
        {
            ValidationDomain(grossSalary,
                             employeId);
            Active  = active;
        }

        private void ValidationDomain(decimal grossSalary,
                                      int employeId)
        {
            DomainExceptionValidation.When(grossSalary <= 0,
                                           "Invalid Gross Salary, must be greater than zero.");
            DomainExceptionValidation.When(employeId < 0,
                                           "Invalid Employee ID, must be greater than zero.");
            GrossSalary = grossSalary;
            EmployeeId  = employeId;
        }
    }
}