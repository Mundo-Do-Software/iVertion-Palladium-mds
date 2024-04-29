
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class EmployeeAddress : Entity
    {
        public int EmployeeId { get; private set; }
        public IEnumerable<Employee>? Employees { get; set; }
        public int AddressId { get; private set; }
        public IEnumerable<Address>? Addresses { get; set; }

        public EmployeeAddress(int employeId,
                               int addressId,
                               bool active)
        {
            ValidationDomain(employeId,
                             addressId);
            Active  = active;
        }
        public EmployeeAddress(int id,
                               int employeId,
                               int addressId,
                               bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(employeId,
                             addressId);
            Id      = id;
            Active  = active;
        }
        public void Update(int employeId,
                           int addressId,
                           bool active)
        {
            ValidationDomain(employeId,
                             addressId);
            Active  = active;
        }

        private void ValidationDomain(int employeId,
                                      int addressId)
        {
            DomainExceptionValidation.When(employeId <= 0,
                                           "Invalid Employee Id, must be up to zero.");
            DomainExceptionValidation.When(addressId <= 0,
                                           "Invalid Address Id, must be up to zero.");
            EmployeeId  = employeId;
            AddressId   = addressId;
        }
    }
}