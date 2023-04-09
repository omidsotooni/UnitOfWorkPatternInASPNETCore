using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string StreetAdress { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string EmailAdress { get; set; }
    }
}