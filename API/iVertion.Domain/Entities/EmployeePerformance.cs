
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class EmployeePerformance : Entity
    {
        public int EmployeeId { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }
        public int PerformanceId { get; private set; }
        public IEnumerable<Performance>? Performances { get; set; }

        public EmployeePerformance(int employeId,
                                   int performanceId,
                                   bool active)
        {
            ValidationDomain(employeId,
                             performanceId);
            Active  = active;
        }
        public EmployeePerformance(int id,
                                   int employeId,
                                   int performanceId,
                                   bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(employeId,
                             performanceId);
            Id      = id;
            Active  = active;
        }
        public void Update(int employeId,
                           int performanceId,
                           bool active)
        {
            ValidationDomain(employeId,
                             performanceId);
            Active  = active;
        }

        private void ValidationDomain(int employeId,
                                      int performanceId)
        {
            DomainExceptionValidation.When(employeId <= 0,
                                           "Invalid Employee Id, must be up to zero.");
            DomainExceptionValidation.When(performanceId <= 0,
                                           "Invalid Performance Id, must be up to zero.");
            EmployeeId  = employeId;
            PerformanceId   = performanceId;
        }
    }
}