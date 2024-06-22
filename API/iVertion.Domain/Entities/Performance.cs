
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class Performance : Entity
    {
        public decimal Grade { get; private set; }
        public string? EmployeeFullName { get; private set; }
        public string? ManagerFullName { get; private set; }
        public DateOnly StartedOnDate { get; private set; }
        public DateOnly DeliveredOnDate { get; private set; }
        public int PerformanceAssessmentId { get; private set; }
        public PerformanceAssessment? PerformanceAssessment { get; set; }
        public IEnumerable<PerformanceQuestion>? PerformanceQuestions { get; set; }

        public Performance(decimal grade,
                           string employeeFullName,
                           string managerFullName,
                           DateOnly startedOnDate,
                           DateOnly deliveredOnDate,
                           int performanceAssessmentId,
                           bool active)
        {
            ValidationDomain(grade,
                             employeeFullName,
                             managerFullName,
                             startedOnDate,
                             deliveredOnDate,
                             performanceAssessmentId);
            Active  = active;
            
        }
        public Performance(int id,
                           decimal grade,
                           string employeeFullName,
                           string managerFullName,
                           DateOnly startedOnDate,
                           DateOnly deliveredOnDate,
                           int performanceAssessmentId,
                           bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(grade,
                             employeeFullName,
                             managerFullName,
                             startedOnDate,
                             deliveredOnDate,
                             performanceAssessmentId);
            Id      = id;
            Active  = active;
            
        }
        public void Update(decimal grade,
                           string employeeFullName,
                           string managerFullName,
                           DateOnly startedOnDate,
                           DateOnly deliveredOnDate,
                           int performanceAssessmentId,
                           bool active)
        {
            ValidationDomain(grade,
                             employeeFullName,
                             managerFullName,
                             startedOnDate,
                             deliveredOnDate,
                             performanceAssessmentId);
            Active  = active;
            
        }

        private void ValidationDomain(decimal grade,
                                      string employeeFullName,
                                      string managerFullName,
                                      DateOnly startedOnDate,
                                      DateOnly deliveredOnDate,
                                      int performanceAssessmentId)
        {
            DomainExceptionValidation.When(grade < 0,
                                           "Invalid Grade, must not be negative.");
            DomainExceptionValidation.When(grade > 100,
                                           "Invalid Grade, the maximum value is 100.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(employeeFullName) || String.IsNullOrWhiteSpace(employeeFullName),
                                           "Invalid employee's full name, cannot be null, empty or a blank space.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(managerFullName) || String.IsNullOrWhiteSpace(managerFullName),
                                           "Invalid manager's full name, cannot be null, empty or a blank space.");
            DomainExceptionValidation.When(startedOnDate > deliveredOnDate,
                                           "Invalid delivery date, cannot be greater than the start date.");
            DomainExceptionValidation.When(performanceAssessmentId < 0,
                                           "Invalid Performance Assessment Id, must be up to zero.");
            Grade                   = grade;
            EmployeeFullName        = employeeFullName;
            ManagerFullName         = managerFullName;
            StartedOnDate           = startedOnDate;
            DeliveredOnDate         = deliveredOnDate;
            PerformanceAssessmentId = performanceAssessmentId;
        }
    }
}