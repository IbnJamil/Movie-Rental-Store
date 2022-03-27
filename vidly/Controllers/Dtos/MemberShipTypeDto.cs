using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.Dtos
{
    public class MemberShipTypeDto
    {  
        public MemberShip Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string MemberShipCatagory { get; set; }
    }
}