
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class BusinessGroup : Entity
    {
        public string? Name { get; private set; }
        public int TypeOfOrganizationalStructureId { get; private set; }
        public TypeOfOrganizationalStructure? TypeOfOrganizationalStructure { get; set; }
        public int TypeOfGeographicCoverageId { get; private set; }
        public TypeOfGeographicCoverage? TypeOfGeographicCoverage { get; set; }
        public IEnumerable<Company>? Companies { get; set; }

        public BusinessGroup(string name,
                             int typeOfOrganizationalStructureId,
                             int typeOfGeographicCoverageId,
                             bool active)
        {
            ValidationDomain(name,
                             typeOfOrganizationalStructureId,
                             typeOfGeographicCoverageId);
            Active = active;

        }
        public BusinessGroup(int id,
                             string name,
                             int typeOfOrganizationalStructureId,
                             int typeOfGeographicCoverageId,
                             bool active)
        {
            DomainExceptionValidation.When(id <= 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(name,
                             typeOfOrganizationalStructureId,
                             typeOfGeographicCoverageId);
            Active = active;

        }
        public void Update(string name,
                           int typeOfOrganizationalStructureId,
                           int typeOfGeographicCoverageId,
                           bool active)
        {
            ValidationDomain(name,
                             typeOfOrganizationalStructureId,
                             typeOfGeographicCoverageId);
            Active = active;

        }

        private void ValidationDomain(string? name,
                                      int typeOfOrganizationalStructureId,
                                      int typeOfGeographicCoverageId)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name),
                                           "Name cannot be null or empty.");
            DomainExceptionValidation.When(name?.Length < 5,
                                           "Name must have at least 5 characters.");
            DomainExceptionValidation.When(name?.Length > 255,
                                           "Name must have a maximum of 255 characters.");
            DomainExceptionValidation.When(typeOfOrganizationalStructureId <= 0,
                                           "Invalid Type Of Organizational Structure Id, must be up to zero.");
            DomainExceptionValidation.When(typeOfGeographicCoverageId <= 0,
                                           "Invalid Type Of Geographic Coverage Id, must be up to zero.");

            Name = name;
            TypeOfOrganizationalStructureId = typeOfOrganizationalStructureId;
            TypeOfGeographicCoverageId = typeOfGeographicCoverageId;
        }
    }
}