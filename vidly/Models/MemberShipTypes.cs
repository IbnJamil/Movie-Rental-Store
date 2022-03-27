using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MemberShipTypes
    {  
       
        public MemberShip Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string MemberShipCatagory { get; set; }
    }
    public enum MemberShip
    {
        trial = 1,
        Basic = 2,
        Silver = 3,
        Gold = 4
    }
}