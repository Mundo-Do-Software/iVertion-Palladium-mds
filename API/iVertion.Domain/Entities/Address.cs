
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public class Address : Entity
    {
        public string? ZipCode { get; private set; }
        public string? Street { get; private set; }
        public string? Number { get; private set; }
        public string? Complement { get; private set; }
        public int NeighborhoodId { get; private set; }
        public Neighborhood? Neighborhood { get; set; }
        public int CityId { get; private set; }
        public City? City { get; set; }
        public int StateId { get; private set; }
        public State? State { get; set; }
        public int CountryId { get; private set; }
        public Country? Country { get; set; }

        public List<CompanyAddress>? CompanyAddresses { get; set; }

        public Address(string zipCode,
                       string street,
                       string number,
                       string complement,
                       int neighborhoodId,
                       int cityId,
                       int stateId,
                       int countryId,
                       bool active)
        {
            ValidationDomain(zipCode,
                             street,
                             number,
                             complement,
                             neighborhoodId,
                             cityId,
                             stateId,
                             countryId);
            Active  = active;
        }
        public Address(int id,
                       string zipCode,
                       string street,
                       string number,
                       string complement,
                       int neighborhoodId,
                       int cityId,
                       int stateId,
                       int countryId,
                       bool active)
        {
            DomainExceptionValidation.When(id < 0,
                                           "Invalid Id, must be up to zero.");
            ValidationDomain(zipCode,
                             street,
                             number,
                             complement,
                             neighborhoodId,
                             cityId,
                             stateId,
                             countryId);
            Id      = id;                             
            Active  = active;
        }
        public void Update(string zipCode,
                           string street,
                           string number,
                           string complement,
                           int neighborhoodId,
                           int cityId,
                           int stateId,
                           int countryId,
                           bool active)
        {
            ValidationDomain(zipCode,
                             street,
                             number,
                             complement,
                             neighborhoodId,
                             cityId,
                             stateId,
                             countryId);
            Active  = active;
        }

        private void ValidationDomain(string zipCode,
                                      string street,
                                      string number,
                                      string complement,
                                      int neighborhoodId,
                                      int cityId,
                                      int stateId,
                                      int countryId)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(zipCode),
                                           "Invalid Zip Code, must not be null or empty!");
            DomainExceptionValidation.When(zipCode.Length < 5,
                                           "Invalid Zip Code, too short, minimum 5 characters!");
            DomainExceptionValidation.When(zipCode.Length > 15,
                                           "Invalid Zip Code, too long, max 15 characters!");
            DomainExceptionValidation.When(String.IsNullOrEmpty(street),
                                           "Invalid Street, must not be null or empty!");
            DomainExceptionValidation.When(street.Length < 5,
                                           "Invalid Street, too short, minimum 5 characters!");
            DomainExceptionValidation.When(street.Length > 255,
                                           "Invalid Street, too long, max 255 characters!");
            DomainExceptionValidation.When(String.IsNullOrEmpty(number),
                                           "Invalid Number, must not be null or empty!");
            DomainExceptionValidation.When(number.Length < 5,
                                           "Invalid Number, too short, minimum 5 characters!");
            DomainExceptionValidation.When(number.Length > 15,
                                           "Invalid Number, too long, max 15 characters!");
            DomainExceptionValidation.When(String.IsNullOrEmpty(complement),
                                           "Invalid Complement, must not be null or empty!");
            DomainExceptionValidation.When(complement.Length < 5,
                                           "Invalid Complement, too short, minimum 5 characters!");
            DomainExceptionValidation.When(complement.Length > 150,
                                           "Invalid Complement, too long, max 150 characters!");
            DomainExceptionValidation.When(neighborhoodId < 0,
                                           "Invalid Neighborhood Id, must be up to zero.");
            DomainExceptionValidation.When(cityId < 0,
                                           "Invalid City Id, must be up to zero.");
            DomainExceptionValidation.When(stateId < 0,
                                           "Invalid State Id, must be up to zero.");
            DomainExceptionValidation.When(countryId < 0,
                                           "Invalid COuntry Id, must be up to zero.");
            ZipCode         = zipCode;
            Street          = street;
            Number          = number;
            Complement      = complement;
            NeighborhoodId  = neighborhoodId;
            CityId          = cityId;
            StateId         = stateId;
            CountryId       = countryId;
        }
    }
}