using System;
using vidly.Models;

namespace vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string CustomersName { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? BirthDate { get; set; }
        public virtual MemberShipTypeDto MemberShipTypeDto { get; set; }
        public MemberShip MemberShipTypesId { get; set; }
       
    }

}