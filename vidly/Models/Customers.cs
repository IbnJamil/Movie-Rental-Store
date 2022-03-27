using System;
using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string CustomersName { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? BirthDate { get; set; }
        public virtual MemberShipTypes MemberShipTypes { get; set; }
        public MemberShip MemberShipTypesId { get; set; }
    }

}