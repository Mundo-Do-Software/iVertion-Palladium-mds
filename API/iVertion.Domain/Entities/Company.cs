
namespace iVertion.Domain.Entities
{
    public class Company : Entity
    {
        public string? Name { get; private set; }
        public string? Cnpj { get; private set; }
        public string? StateRegistration { get; private set; }
        public string? BusinesLicense { get; private set; }
    }
}