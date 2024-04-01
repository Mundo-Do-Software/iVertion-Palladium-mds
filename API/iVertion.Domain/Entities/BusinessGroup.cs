
namespace iVertion.Domain.Entities
{
    public class BusinessGroup : Entity
    {
        public string? Name { get; private set; }
        public IEnumerable<Company>? Companies { get; set; }
    }
}