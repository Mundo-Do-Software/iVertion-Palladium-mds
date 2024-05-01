
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public class EmployeeSkill : Entity
    {
        public int EmployeeId { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }
        public int SkillId { get; private set; }
        public IEnumerable<Skill>? Skills { get; set; }

        public EmployeeSkill(int employeId,
                             int skillId,
                             bool active)
        {
            ValidationDomain(employeId,
                             skillId);
            Active  = active;
        }
        public EmployeeSkill(int id,
                             int employeId,
                             int skillId,
                             bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(employeId,
                             skillId);
            Id      = id;
            Active  = active;
        }
        public void Update(int employeId,
                           int skillId,
                           bool active)
        {
            ValidationDomain(employeId,
                             skillId);
            Active  = active;
        }

        private void ValidationDomain(int employeId,
                                      int skillId)
        {
            DomainExceptionValidation.When(employeId <= 0,
                                           "Invalid Employee Id, must be up to zero.");
            DomainExceptionValidation.When(skillId <= 0,
                                           "Invalid Skill Id, must be up to zero.");
            EmployeeId  = employeId;
            SkillId   = skillId;
        }
    }
}